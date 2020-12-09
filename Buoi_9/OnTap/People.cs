using System;
using System.Collections.Generic;
using System.Text;

namespace OnTap
{
    class People
    {
        private string name;
        private string age;

        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }

        public People() { }

        public People(string name, string age)
        {
            Name = name;
            Age = age;
        }
    }
}
