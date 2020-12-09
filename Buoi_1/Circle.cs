using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_1
{
    class Circle
    {
        private double r;
        public double R { get => r; set => r = value; }

        //Parameterless or Default Constructor
        public Circle()
        {
            R = 1;
        }
        public Circle(double r)
        {
            R = r;
        }
        public void Input()
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            r = double.Parse(Console.ReadLine());
        }
        public double Area()
        {
            return Math.PI * (R*R);
        }
        public double Perimeter()
        {
            return 2 * Math.PI * R;
        }
        
    }
}
