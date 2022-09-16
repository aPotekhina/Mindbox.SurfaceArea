using System;
using System.Collections.Generic;
using Mindbox.SurfaceArea.Core;
using Mindbox.SurfaceArea.Core.Circle;
using Mindbox.SurfaceArea.Core.Triangle;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var tr = new Triangle(6, 5, 10);
            Console.WriteLine(tr.SideA);
            Console.WriteLine(tr.RightTriangleCheck());
            
            var list = new List<IFigure>();
            list.Add(new Circle(3));
            list.Add(new Triangle(3, 5, 7));
            list.Add(new Triangle(4, 4, 7));
            list.Add(new Circle(6));
            list.Add(new Circle(1));
            list.Add(new Triangle(3, 4, 5));
            foreach (var l in list)
            {
                Console.WriteLine(l.CalculateSurfaceArea());
            }
            
            var y = new Triangle(3, 4, 5);
            Console.WriteLine(y.RightTriangleCheck());

            var u = new Triangle(0.000000003, 0.000000004, 0.000000006);
            Console.WriteLine(u.RightTriangleCheck());
        }
    }
}