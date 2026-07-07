using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeManager
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            if (employees.Any(e => e.Id == employee.Id))
            {
                Console.WriteLine("Employee ID Already Exists.");
                return;
            }

            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully.");
        }

        public void ShowAllEmployees()
        {
            foreach (Employee emp in employees)
            {
                emp.Display();
            }
        }

        public void ShowITEmployees()
        {
            var result = employees.Where(e => e.Department == "IT");

            foreach (Employee emp in result)
            {
                emp.Display();
            }
        }

        public void ShowHighSalaryEmployees()
        {
            var result = employees.Where(e => e.Salary > 50000);

            foreach (Employee emp in result)
            {
                emp.Display();
            }
        }

        public void SearchEmployee(int id)
        {
            Employee emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp != null)
                emp.Display();
            else
                Console.WriteLine("Employee Not Found.");
        }

        public void ShowEmployeeNames()
        {
            var result = employees.Select(e => e.Name);

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        public void SortBySalary()
        {
            var result = employees.OrderByDescending(e => e.Salary);

            foreach (Employee emp in result)
            {
                emp.Display();
            }
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"Total Employees : {employees.Count()}");
            Console.WriteLine($"IT Employees : {employees.Count(e => e.Department == "IT")}");
            Console.WriteLine($"Highest Salary : {employees.Max(e => e.Salary)}");
            Console.WriteLine($"Lowest Salary : {employees.Min(e => e.Salary)}");
            Console.WriteLine($"Average Salary : {employees.Average(e => e.Salary)}");
            Console.WriteLine($"Total Salary : {employees.Sum(e => e.Salary)}");
        }
    }
}