using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        protected string name;
        protected double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public Product() { }
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "Product[name= " + Name
                + ",price= " + Price + "]";
        }
    }
}
