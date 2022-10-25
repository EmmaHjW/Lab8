using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            string empInfo = $"Employees:\nID: {EmpId}\nName: {Name}\nGender: {Gender}\nSalary: {Salary}";
            return empInfo;
        }
    }
}
