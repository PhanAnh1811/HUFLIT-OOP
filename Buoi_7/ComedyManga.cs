using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_7
{
    class ComedyManga : Manga
    {
        private string _type;


        public ComedyManga(string _id, string _name, string _author, int _amount, string _type)
            : base(_id, _name, _author, _amount)
        {
            this.Id = _id;
            this._name = _name;
            this._author = _author;
            this.Amount = _amount;
            this._type = _type;
        }

        public ComedyManga() { }

        public override void Input()
        {
            Console.WriteLine("=========== Nhập thông tin truyện tiểu thuyết ===========");
            base.Input();
            Console.Write("Enter Type : ");
            this._type = Console.ReadLine();

        }

        public override void Output()
        {
            Console.WriteLine("=========== Truyện tiểu thuyết ===========");
            base.Output();
            Console.WriteLine("Type : " + this._type);
        }
    }
}
