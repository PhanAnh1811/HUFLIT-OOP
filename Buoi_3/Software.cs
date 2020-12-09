using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Software:Product
    {
        protected string version;
        public string Version { get => version; set => version = value; }
        public Software() { }
        public Software(string name, double price, string version)
            : base(name, price)
        {
            Name = name;
            Price = price;
            Version = version;
        }
        public override string ToString()
        {
            return base.ToString()
                + ", Software[version= " + Version + "]";
        }
    }
}
