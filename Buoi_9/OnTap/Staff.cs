using System;
using System.Collections.Generic;
using System.Text;

namespace OnTap
{
    class Staff:People
    {
        private string staffCode;
        private string salary;
        private string countribute;

        public Staff(string staffCode, string salary, string countribute)
        {
            this.staffCode = staffCode;
            this.salary = salary;
            this.countribute = countribute;
        }

        public string StaffCode { get => staffCode; set => staffCode = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Countribute { get => countribute; set => countribute = value; }
    }
}
