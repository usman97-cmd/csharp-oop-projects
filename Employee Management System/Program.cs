using System;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();

        while (true)
        {
            Console.WriteLine("\n===== Employee Management System =====");
            Console.WriteLine("1. Add Developer");
            Console.WriteLine("2. Add Manager");
            Console.WriteLine("3. Add Designer");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Search Employee");
            Console.WriteLine("6. Remove Employee");
            Console.WriteLine("7. Exit");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("ID: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    string dname = Console.ReadLine()!;

                    Console.Write("Salary: ");
                    double dsalary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Programming Language: ");
                    string language = Console.ReadLine()!;

                    Employee developer = new Developer(did, dname, dsalary, language);

                    manager.AddEmployee(developer);

                    break;

                case 2:

                    Console.Write("ID: ");
                    int mid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    string mname = Console.ReadLine()!;

                    Console.Write("Salary: ");
                    double msalary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Department: ");
                    string department = Console.ReadLine()!;

                    Employee managerObj = new Manager(mid, mname, msalary, department);

                    manager.AddEmployee(managerObj);

                    break;

                case 3:

                    Console.Write("ID: ");
                    int desid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    string desname = Console.ReadLine()!;

                    Console.Write("Salary: ");
                    double dessalary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Design Tool: ");
                    string tool = Console.ReadLine()!;

                    Employee designer = new Designer(desid, desname, dessalary, tool);

                    manager.AddEmployee(designer);

                    break;

                case 4:

                    manager.DisplayEmployees();

                    break;

                case 5:

                    Console.Write("Enter Employee ID: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());

                    manager.SearchEmployee(searchId);

                    break;

                case 6:

                    Console.Write("Enter Employee ID: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());

                    manager.RemoveEmployee(removeId);

                    break;

                case 7:

                    return;

                default:

                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}