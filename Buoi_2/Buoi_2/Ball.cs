using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Buoi_2
{
    class Ball
    {
        private int size;
        private int timeOfThrown;
        private Color myBallColor;

        public int Size { get => size; set => size = value; }
        public int TimeOfThrown { get => timeOfThrown; set => timeOfThrown = value; }
        public Color MyBallColor { get => myBallColor; set => myBallColor = value; }
        public Ball()
        {
            Size = 1;
            TimeOfThrown = 0;
            MyBallColor = new Color();
        }
        public Ball(int size,int timeOfThrown,Color myBallColor)
        {
            Size = size;
            TimeOfThrown = timeOfThrown;
            MyBallColor = myBallColor;
        }
        public void Pop()
        {
            Size = 0;
        }
        public bool isPop()
        {
            return size == 0 ? true : false;
        }

        public int Throw()
        {
            return !isPop() ? TimeOfThrown++ : 0;
        }
        public void Input()
        {
            Console.WriteLine("Nhap kich thuoc: ");
            Size = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so lan nem: ");
            TimeOfThrown = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Size: " + Size);
            Console.WriteLine("So lan nem: " + TimeOfThrown);
            Console.WriteLine("Color: " + MyBallColor.ToString());
        }
    }
}
