using System;
using System.Collections.Generic;

class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("Employee Added Successfully.");
    }

    public void DisplayEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No Employee Found.");
            return;
        }

        foreach (Employee employee in employees)
        {
            employee.Display();
            employee.Work();
            Console.WriteLine("----------------------------");
        }
    }

    public void SearchEmployee(int id)
    {
        foreach (Employee employee in employees)
        {
            if (employee.GetId() == id)
            {
                employee.Display();
                employee.Work();
                return;
            }
        }

        Console.WriteLine("Employee Not Found.");
    }

    public void RemoveEmployee(int id)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i].GetId() == id)
            {
                employees.RemoveAt(i);
                Console.WriteLine("Employee Removed Successfully.");
                return;
            }
        }

        Console.WriteLine("Employee Not Found.");
    }
}
