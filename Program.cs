using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee { Name = "Güler", Department = "Sales", Salary = 50000.00m },
                new Employee { Name = "Chris", Department = "Marketing", Salary = 45000.00m },
                new Employee { Name = "Lasse", Department = "Sales", Salary = 60000.00m },
                new Employee { Name = "David", Department = "Sales", Salary = 55000.00m },
                new Employee { Name = "Troels", Department = "Marketing", Salary = 40000.00m },
                new Employee { Name = "Kenneth", Department = "Sales", Salary = 70000.00m },
                new Employee { Name = "Maja", Department = "Sales", Salary = 65000.00m },
                new Employee { Name = "Victor", Department = "Marketing", Salary = 42000.00m },
                new Employee { Name = "Niels", Department = "Sales", Salary = 55000.00m },
                new Employee { Name = "Markus", Department = "Sales", Salary = 48000.00m },
            };

            //Finds all emloyees that works for the sales department. 
            var salesEmployees = from e in employees
                             where e.Department == "Sales"
                             select e;


            //Sorts all employees by salary in acending order. 
            var sortedEmployees = from e in salesEmployees
                              orderby e.Salary, e.Name
                              select e;

        }

        public class Employee
        {
            public string? Name { get; set; }
            public string? Department { get; set; }
            public decimal Salary { get; set; }
        }
    }
}
