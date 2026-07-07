using System;

namespace EmployeeManagement.Models
{
    public class Manager : Employee
    {
        public int TeamSize;

        public Manager(int id, string name, string department,
            double salary, int teamSize)
            : base(id, name, department, salary)
        {
            TeamSize = teamSize;
        }

        public override void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Team Size : {TeamSize}");
        }
    }
}