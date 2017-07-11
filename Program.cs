using System;
using System.Collections.Generic;

namespace classes
{

    public class Company
    {
        // Some readonly properties
        public string Name { get; }
        public DateTime CreatedOn { get; set; }

        // Create a property for holding a list of current employees
        private List<Employee> employeeList { get; set; } = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void AddEmployee (Employee newEmployee) {
            employeeList.Add(newEmployee);
        }

        // Create a method that allows external code to remove an employee
        public void RemoveEmployee (Employee axed)
        {
            employeeList.Remove(axed); 
        }

        public void ShowEmployees()
        {
            foreach (Employee e in employeeList) {
                Console.WriteLine(e.Name);
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company (string newCompany, DateTime created)
        {
            this.Name = newCompany;
            this.CreatedOn = created;
        }
    }

    public class Employee
    {
       public string Name { get; set; }
       public string JobTitle { get; set; }
       public DateTime StartDate { get; set; }
       public string EmployeeNumber { get; set;}

       public Employee (string newName, string newJobTitle, DateTime newStartDate, string employeeNumber)
       {
           this.Name = newName;
           this.JobTitle = newJobTitle;
           this.StartDate = newStartDate;
           this.EmployeeNumber = employeeNumber;
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company MakePaper = new Company("MakePaper", new DateTime(2017, 1, 1).Date);
            Console.WriteLine($"{MakePaper.Name} was founded {MakePaper.CreatedOn.ToString("d")}");

            Employee e101 = new Employee("Jack", "VP", new DateTime(2017, 6, 1, 7, 47, 0).Date, "e101");
            Employee e102 = new Employee("Jordan", "Founder", new DateTime(2017, 1, 1).Date, "e102");
            Employee e103 = new Employee("Jill", "CHRO", new DateTime(2017, 5, 1).Date, "e103");

            MakePaper.AddEmployee(e101);
            MakePaper.AddEmployee(e102);
            MakePaper.AddEmployee(e103);

            MakePaper.ShowEmployees();

            MakePaper.RemoveEmployee(e101);
            MakePaper.ShowEmployees();


        }
    }
}

