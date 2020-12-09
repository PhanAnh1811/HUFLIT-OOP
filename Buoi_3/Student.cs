using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student:Person
    {
        protected string studentID;

        public string StudentID { get => studentID; set => studentID = value; }
        public Student() { }
        public Student(string email,string name,string studentID)
            : base(email, name)
        {
            Email = email;
            Name = name;
            StudentID = studentID;
        }
        public override string ToString()
        {
            return base.ToString() +
                ", Student[studentID= " + StudentID + "]";
        }
    }
}
