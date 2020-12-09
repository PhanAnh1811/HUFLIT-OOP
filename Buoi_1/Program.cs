using System;

namespace Buoi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1
            #region Account
            Account account = new Account("123456", 1000000);
            Console.WriteLine(" Thong tin tai khoan hien tai ");
            Console.WriteLine(account.ToString());
            Account account1 = new Account("123456", 800000);
            Console.WriteLine("Thong tin tai khoan sau khi cap nhat ");
            Console.WriteLine(account.ToString());
            #endregion

            //Bai 2
            #region Book
            Book book = new Book("B1234", "Mindset", 70000, 7000);
            Console.WriteLine("Thong tin quyen sach hien tai");
            Console.WriteLine(book.ToString());
            Console.WriteLine("Gia ban cua sach: " + book.MoneyForBook());
            Console.WriteLine();
            Book book1 = new Book("B1234", "Mindset", 70000, 24000);
            Console.WriteLine("Thong tin quyen sach sau khi cap nhat");
            Console.WriteLine(book1.ToString());
            Console.WriteLine("Gia ban cua sach: " + book1.MoneyForBook());
            #endregion

            //Bai 3
            #region Student
            Student student = new Student("TH151234", "Nguyen Van A", 1997,
                "123 Nguyen Trai, P10, Q5, Tp.HCM");
            Console.WriteLine(student.ToString());
            Console.WriteLine("Tuoi cua sinh vien: " + student.AgeOfStudent());
            #endregion

            //Bai 4
            #region Circle
            Circle circle = new Circle();
            circle.Input();
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimeter());
            #endregion
        }
    }
}
