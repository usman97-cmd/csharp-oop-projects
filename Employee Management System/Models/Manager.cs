using System;

class Manager : Employee
{
    private string department;

    public Manager(int id, string name, double salary, string department)
        : base(id, name, salary)
    {
        this.department = department;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Department: {department}");
    }

    public override void Work()
    {
        Console.WriteLine($"{name} is managing {department} department.");
    }
}