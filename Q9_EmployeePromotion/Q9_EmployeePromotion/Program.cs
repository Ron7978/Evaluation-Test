using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_EmployeePromotion
{
    public delegate void promotion(string msg);
    internal class Program
    {
        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int salary { get; set; }
            public float Experiance { get; set; }

            public static void PromoteEmp(List<Employee> EmployeeList)
            {
                foreach (Employee emp in EmployeeList)
                {
                    if (emp.Experiance >= 5)//logic condition  
                    {
                        Console.WriteLine(emp.Name + " promoted");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "Soham", salary = 20000, Experiance = 3 });
            empl.Add(new Employee() { ID = 102, Name = "Akshat", salary = 30000, Experiance = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Rounak", salary = 50000, Experiance = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Nilesh", salary = 10000, Experiance = 2 });
            Employee.PromoteEmp(empl);

            Console.ReadLine();
        }
    }
}


