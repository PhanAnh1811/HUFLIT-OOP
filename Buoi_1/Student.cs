using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_1
{
    class Student
    {
        private string codeSV;
        private string fullName;
        private int year;
        private string address;

        public string CodeSV { get => codeSV; set => codeSV = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Year { get => year; set => year = value; }
        public string Address { get => address; set => address = value; }

        public Student() { }
        public Student (string codeSV,string fullName)
        {
            CodeSV = codeSV;
            FullName = fullName;
        }
        public Student(string codeSV,string fullName,int year,string address)
        {
            CodeSV = codeSV;
            FullName = fullName;
            Year = year;
            Address = address;
        }
        public int AgeOfStudent()
        {
            return DateTime.Now.Year - Year;
        }
        public override string ToString()
        {
            return "Ma sinh vien: " + CodeSV + "\n"
                + "Ho ten: " + FullName + "\n"
                + "Nam sinh: " + Year + "\n"
                + "Dia chi: " + Address + "\n";
        }
    }
}
