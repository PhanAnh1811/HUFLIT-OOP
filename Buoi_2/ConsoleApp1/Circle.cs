using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle:IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
