using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        protected string email;
        protected string name;

        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public Person() { }
        public Person(string email, string name)
        {
            Email = email;
            Name = name;
        }
        public override string ToString()
        {
            return "Person[email= "+Email
                +", name= "+Name+"]";
        }
    }
}
