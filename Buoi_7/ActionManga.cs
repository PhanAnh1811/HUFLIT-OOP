using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_7
{
    class ActionManga : Manga
    {
        private int _action;


        public ActionManga(string _id, string _name, string _author, int _amount, int _action)
            : base(_id, _name, _author, _amount)
        {
            this.Id = _id;
            this._name = _name;
            this._author = _author;
            this.Amount = _amount;
            this._action = _action;
        }

        public ActionManga() { }

        public override void Input()
        {
            Console.WriteLine("=========== Nhập thông tin truyện hành động ===========");
            base.Input();
            Console.Write("Enter Action Rate : ");
            this._action = int.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            Console.WriteLine("=========== Truyện hành động  ===========");
            base.Output();
            Console.WriteLine("Action : " + this._action);
        }
    }
}
