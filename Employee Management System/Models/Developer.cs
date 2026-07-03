using System;

class Developer : Employee
{
    private string language;

    public Developer(int id, string name, double salary, string language)
        : base(id, name, salary)
    {
        this.language = language;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Programming Language: {language}");
    }

    public override void Work()
    {
        Console.WriteLine($"{name} is writing {language} code.");
    }
}