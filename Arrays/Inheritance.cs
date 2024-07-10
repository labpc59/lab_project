using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNameSpace
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee(1, "shreyas", 1200000.00, false));
            foreach (Employee e in EmployeeList) 
            {
                Console.WriteLine(e.getName());
                Console.WriteLine(e.Salary);

            }


        }

        

        public class Employee
        {
            private int id { get; set; }
            private string name { get; set; }
            private double salar { get; set; }
            private bool handicape { get; set; }

            public Employee()
            { }
            public Employee(int id, string name, double salary, bool handicape)

            {
                this.id = id;
                this.name = name;
                this.salar = salary;
                this.handicape = handicape;
            }
            public string getName()
            {
                return name;
            }
            public double Salary{
            get { return salar; } 
            }
           

        }



     }
}
