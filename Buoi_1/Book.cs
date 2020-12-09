using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_1
{
    class Book
    {
        private string codeBook;
        private string nameBook;
        private int price;
        private int discount;

        public string CodeBook { get => codeBook; set => codeBook = value; }
        public string NameBook { get => nameBook; set => nameBook = value; }
        public int Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        
        public Book() { }
        public Book(string codeBook,string nameBook)
        {
            CodeBook =codeBook;
            NameBook=nameBook;
        }
        public Book(string codeBook,string nameBook,int price,int discount)
        {
            CodeBook=codeBook;
            NameBook=nameBook;
            Price=price;
            Discount=discount;
        }
        
        public double MoneyForBook()
        {
            return price - discount;
        }
        public override string ToString()
        {
            return "-Ma so sach: " + CodeBook + "\n"
                + "-Ten sach: " + NameBook + "\n"
                + "-Gia sach: " + Price + "\n"
                + "-Giam gia: " + Discount + "\n";
        }
    }
}
