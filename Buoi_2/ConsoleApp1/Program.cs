using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> myList = new List<IShape>();
            myList.Add(new Rectangle());
             double s = myList[0].Area();
            Console.WriteLine(s);
        }
    }
}
