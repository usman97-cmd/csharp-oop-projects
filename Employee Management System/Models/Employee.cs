using System;

namespace EmployeeManagement.Models
{
    public abstract class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public abstract void Display();
    }
}