using System;
using EmployeeManagement.Models;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine(" Employee Management System ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add Developer");
                Console.WriteLine("2. Add Manager");
                Console.WriteLine("3. Show All Employees");
                Console.WriteLine("4. Show IT Employees");
                Console.WriteLine("5. Show High Salary Employees");
                Console.WriteLine("6. Search Employee By ID");
                Console.WriteLine("7. Show Employee Names");
                Console.WriteLine("8. Sort Employees By Salary");
                Console.WriteLine("9. Show Statistics");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter ID : ");
                        int did = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name : ");
                        string dname = Console.ReadLine();

                        Console.Write("Enter Department : ");
                        string ddepartment = Console.ReadLine();

                        Console.Write("Enter Salary : ");
                        double dsalary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Programming Language : ");
                        string language = Console.ReadLine();

                        Developer developer =
                            new Developer(did, dname, ddepartment, dsalary, language);

                        manager.AddEmployee(developer);

                        break;

                    case 2:

                        Console.Write("Enter ID : ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name : ");
                        string mname = Console.ReadLine();

                        Console.Write("Enter Department : ");
                        string mdepartment = Console.ReadLine();

                        Console.Write("Enter Salary : ");
                        double msalary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Team Size : ");
                        int teamSize = Convert.ToInt32(Console.ReadLine());

                        Manager mgr =
                            new Manager(mid, mname, mdepartment, msalary, teamSize);

                        manager.AddEmployee(mgr);

                        break;

                    case 3:

                        manager.ShowAllEmployees();

                        break;

                    case 4:

                        manager.ShowITEmployees();

                        break;

                    case 5:

                        manager.ShowHighSalaryEmployees();

                        break;

                    case 6:

                        Console.Write("Enter Employee ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        manager.SearchEmployee(id);

                        break;

                    case 7:

                        manager.ShowEmployeeNames();

                        break;

                    case 8:

                        manager.SortBySalary();

                        break;

                    case 9:

                        manager.ShowStatistics();

                        break;

                    case 0:

                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue...");
                Console.ReadKey();
            }
        }
    }
}