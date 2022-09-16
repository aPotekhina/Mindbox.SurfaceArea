﻿using System;
using System.Linq;

namespace Mindbox.SurfaceArea.Core.Triangle
{
    public class Triangle : IFigure
    {
        private double _sideA;

        public double SideA
        {
            get => _sideA;
            set
            {
                Validate(value, _sideB, _sideC);
                _sideA = value;
            }
        }

        private double _sideB;

        public double SideB
        {
            get => _sideB;
            set
            {
                Validate(_sideA, value, _sideC);
                _sideB = value;
            }
        }

        private double _sideC;

        public double SideC
        {
            get => _sideC;
            set
            {
                Validate(_sideA, _sideB, value);
                _sideC = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            Validate(a, b, c);
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        private void Validate(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            if (sides.Any(s => s <= 0))
            {
                throw new ArgumentException("Invalid triangle side.");
            }
            var maxSide = sides.Max();
            if (maxSide >= sides.Sum() - maxSide) throw new ArgumentException("Invalid triangle.");
        }

        public double CalculateSurfaceArea()
        {
            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Pow(
                semiPerimeter *
                (semiPerimeter - _sideA) *
                (semiPerimeter - _sideB) *
                (semiPerimeter - _sideC),
                0.5
            );
        }

        public bool RightTriangleCheck()
        {
            var sides = new[] { _sideA, _sideB, _sideC };
            var maxSide = sides.Max();
            var tolerance = 0.000000001;

            if (Math.Abs(2 * Math.Pow(maxSide, 2) - (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2))) <
                tolerance)
                return true;

            return false;
        }
    }
}