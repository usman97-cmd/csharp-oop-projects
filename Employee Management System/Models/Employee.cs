using System;

class Employee
{
    protected int id;
    protected string name;
    protected double salary;

    public Employee(int id, string name, double salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public virtual void Display()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }

    public virtual void Work()
    {
        Console.WriteLine($"{name} is working.");
    }

    public int GetId()
    {
        return id;
    }
}