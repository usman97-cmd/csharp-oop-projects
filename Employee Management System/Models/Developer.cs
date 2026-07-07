using System;

namespace EmployeeManagement.Models
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage;

        public Developer(int id, string name, string department,
            double salary, string programmingLanguage)
            : base(id, name, department, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Language : {ProgrammingLanguage}");
        }
    }
}