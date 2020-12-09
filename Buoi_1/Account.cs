using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_1
{
    class Account
    {
        private string codeAccount;
        private int money;

        public string CodeAccount
        {
            get { return codeAccount; }
            set { codeAccount = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public Account() { }
        public Account(string codeAccount,int money)
        {
            CodeAccount = codeAccount;
            Money = money;
        }
        public override string ToString()
        {
            return "Ma so tai khoan: " + CodeAccount + " \n"
                + "So tien: " + Money + " \n";
        }
    }
}
