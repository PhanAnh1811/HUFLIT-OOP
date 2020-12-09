using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_2
{
    class Color
    {
        private int red;
        private int blue;
        private int green;
        private int alpha;

        public int Red { get => red; set => red = value; }
        public int Blue { get => blue; set => blue = value; }
        public int Green { get => green; set => green = value; }
        public int Alpha { get => alpha; set => alpha = value; }
        public Color() 
        {
            Red = 255;
            Blue = 255;
            Green = 255;
            Alpha = 255;
        }
        public Color(int red,int blue,int green,int alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = alpha;
        }
        public Color(Color color)
        {
            color.Red = red;
            color.Blue = blue;
            color.Green = green;
            color.Alpha = alpha;
        }
        public int GrayScale()
        {
            return (Red + Green + Blue) / 3;
        }
        public void Input()
        {

        }
    }
}
