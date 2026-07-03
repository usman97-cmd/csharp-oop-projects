using System;

class Designer : Employee
{
    private string tool;

    public Designer(int id, string name, double salary, string tool)
        : base(id, name, salary)
    {
        this.tool = tool;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Design Tool: {tool}");
    }

    public override void Work()
    {
        Console.WriteLine($"{name} is designing using {tool}.");
    }
}
