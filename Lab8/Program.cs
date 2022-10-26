using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee E1 = new Employee() { EmpId = 110, Name = "Shawn", Gender = "Male", Salary = 42000 };
            Employee E2 = new Employee() { EmpId = 111, Name = "Aaron", Gender = "Male", Salary = 60000 };
            Employee E3 = new Employee() { EmpId = 112, Name = "Audrey", Gender = "Female", Salary = 58000 };
            Employee E4 = new Employee() { EmpId = 113, Name = "Claire", Gender = "Female", Salary = 42000 };
            Employee E5 = new Employee() { EmpId = 114, Name = "Marcus", Gender = "Male", Salary = 55000 };

            Stack<Employee> EmpStack = new Stack<Employee>();//Last in first out. Push, Pop, Peek
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);

            foreach (Employee item in EmpStack)
            {
                Console.WriteLine(item);
                Console.WriteLine();
                Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
                Console.WriteLine();
            }

            Console.WriteLine(new string('~', 36));
            Console.WriteLine();

            Employee EP = EmpStack.Pop();
            Console.WriteLine(EP.Name);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Employee EP2 = EmpStack.Pop();
            Console.WriteLine(EP2.Name);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Employee EP3 = EmpStack.Pop();
            Console.WriteLine(EP3.Name);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Employee EP4 = EmpStack.Pop();
            Console.WriteLine(EP4.Name);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Employee EP5 = EmpStack.Pop();
            Console.WriteLine(EP5.Name);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Console.WriteLine();

            Console.WriteLine(new string('~', 36));
            Console.WriteLine();

            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);

            Employee e = EmpStack.Peek();
            Console.WriteLine(e.Name + " " + e.EmpId);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Console.WriteLine();
            Employee e2 = EmpStack.Peek();
            Console.WriteLine(e2.Name + " " + e2.EmpId);
            Console.WriteLine("Items kvar i stacken: " + EmpStack.Count);
            Console.WriteLine();

            Console.WriteLine(new string('~', 36));
            Console.WriteLine();

            if (EmpStack.Contains(E2) == true)
            {
                Console.WriteLine(E2.Name + " " + "finns i listan");
            }

            else
            {
                Console.WriteLine(E2.Name + " " + "finns inte i listan");
            }

            Console.WriteLine();
            Console.WriteLine(new string('~', 36));
            Console.WriteLine();

            Employee E6 = new Employee() { EmpId = 115, Name = "Joona", Gender = "Male", Salary = 40000 };
            Employee E7 = new Employee() { EmpId = 116, Name = "Saga", Gender = "Female", Salary = 32000 };
            Employee E8 = new Employee() { EmpId = 117, Name = "Petter", Gender = "Male", Salary = 36000 };
            Employee E9 = new Employee() { EmpId = 118, Name = "Greta", Gender = "Female", Salary = 36000 };
            Employee E10 = new Employee() { EmpId = 119, Name = "Jorek", Gender = "Male", Salary = 10000 };

            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(E6);
            EmpList.Add(E7);
            EmpList.Add(E8);
            EmpList.Add(E9);
            EmpList.Add(E10);

            if (EmpList.Contains(E6) == true)
            {
                Console.WriteLine(E6.Name + " " + "finns i listan");
            }
            else
            {
                Console.WriteLine(E6.Name + " " + "finns inte i listan");
            }

            Console.WriteLine();
            Console.WriteLine(new string('~', 36));
            Console.WriteLine();

            Employee foundEmployee = EmpList.Find(x => x.Gender == "Male");
            Console.WriteLine(foundEmployee);
            List<Employee> GenderResult = new List<Employee>(EmpList.FindAll(i => i.Gender == "Male"));
            Console.WriteLine();
            foreach (var gender in GenderResult)
            {
                Console.WriteLine();
                Console.WriteLine(gender);
                Console.WriteLine();
            }





        }
    }
}
