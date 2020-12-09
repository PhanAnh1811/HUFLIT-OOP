using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Hardware:Product
    {
        protected string weight;
        public string Weight { get => weight; set => weight = value; }
        public Hardware() { }
        public Hardware(string name,double price,string weight)
            : base(name, price)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString()
                + ", Hardware[Weight= " + Weight + "]";
        }
    }
}
