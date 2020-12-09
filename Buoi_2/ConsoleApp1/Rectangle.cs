using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle :IShape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle() { }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public double Area()
        {
            return Width * Height;
        }
    }
}
