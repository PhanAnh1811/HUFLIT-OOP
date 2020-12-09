using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_7
{
    class ChildrenManga : Manga
    {
        private int _age;

        public int Age { get => _age; set => _age = value; }

        public ChildrenManga(string _id,string _name,string _author,int _amount,int _age)
            : base(_id, _name, _author, _amount)
        {
            this.Id = _id;
            this._name = _name;
            this._author = _author;
            this.Amount = _amount;
            this._age = _age;
        }

        public ChildrenManga() { }

        public override void Input()
        {
            Console.WriteLine("=========== Nhập thông tin truyện thiếu nhi ===========");
            base.Input();
            Console.Write("Enter Age : ");
            this._age = int.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            Console.WriteLine("=========== Truyện thiếu nhi ===========");
            base.Output();
            Console.WriteLine("Age : " + this._age);
        }
    }
}
