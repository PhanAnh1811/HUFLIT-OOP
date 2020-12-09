using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_7
{
    abstract class Manga
    {
        private string id;
        protected string _name;
        protected string _author;
        private int amount;

        public int Amount { get => amount; set => amount = value; }
        public string Id { get => id; set => id = value; }

        public Manga(string id, string name, string author, int amount)
        {
            Id = id;
            _name = name;
            _author = author;
            Amount = amount;
        }

        
        public Manga() { }

        public virtual void Input()
        {
            Console.Write("Enter ID : ");
            this.Id = Console.ReadLine();
            Console.Write("Enter Name : ");
            this._name = Console.ReadLine();
            Console.Write("Enter Author : ");
            this._author = Console.ReadLine();
            Console.Write("Enter Amount : ");
            this.Amount = int.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("ID : " + this.Id);
            Console.WriteLine("Name : " + this._name);
            Console.WriteLine("Author : " + this._author);
            Console.WriteLine("Amount : " + this.Amount);
        }


        
    }
}
