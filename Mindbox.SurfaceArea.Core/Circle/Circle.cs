using System;

namespace Mindbox.SurfaceArea.Core.Circle
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                Validate(value);
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Validate(radius);
            Radius = radius;
        }

        private void Validate(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Invalid circle radius.");
        }

        public double CalculateSurfaceArea() =>
            Radius * Radius * Math.PI;
    }
}