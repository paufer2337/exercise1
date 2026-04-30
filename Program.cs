using System;
using System.Collections.Generic;
using System.Linq;





class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public Employee(string firstName, string lastName, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }
    public string Name => $"{FirstName} {LastName}";

}

class Program
{
    static  List<Employee> employees = new();
    static void Main()
    {
        string? action = "";

        while (action != "99")
        {
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("=== Employee Management Overview ===");
            Console.WriteLine();
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. List all employees");
            Console.WriteLine("3. Update employee");
            Console.WriteLine("4. Delete employee");
            Console.WriteLine();
            Console.WriteLine("99. Exit");
            Console.WriteLine();
            Console.Write("Select an action: ");
            Console.WriteLine();


            action = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(action))
            {
                Console.WriteLine("Invalid input. Please select a valid action.");
                continue;
            }
            Console.WriteLine();

            switch (action)
            {
                case "1":
                    AddEmp();
                    break;
                case "2":
                    ListAllEmp();
                    break;
                case "3":
                    UpdateEmp();
                    break;
                case "4":
                    DeleteEmp();
                    break;
                case "99":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddEmp()
    {
        Console.Write("Enter first name: ");
        string? firstName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(firstName))
        {
            Console.Write("First name cannot be empty. Please enter a valid first name: ");
            firstName = Console.ReadLine();
        }

        Console.Write("Enter last name: ");
        string? lastName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(lastName))
        {
            Console.Write("Last name cannot be empty. Please enter a valid last name: ");
            lastName = Console.ReadLine();
        }

        Console.Write("Enter salary: ");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
        {
            Console.WriteLine();
            Console.Write("Invalid input. Please enter a valid salary: ");
        }

        Employee newEmployee = new Employee(firstName, lastName, salary);
        employees.Add(newEmployee);
        Console.WriteLine();
        Console.WriteLine("~ Employee added successfully! ~");
    }


    static void ListAllEmp()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("=== Employee List ===");
        Console.WriteLine();
        foreach (var employee in employees)
        {
            Console.WriteLine($"Full Name: {employee.Name}   |   Salary: {employee.Salary:C}");
        }
    }


    static void UpdateEmp()
    {

        Console.WriteLine("=== Update & Edit Employee ===");
        Console.WriteLine();
        Console.Write("Enter the firstname of the employee to update: ");
        string? firstName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(firstName))
        {
            Console.Write("First name cannot be empty. Please enter a valid first name: ");
            firstName = Console.ReadLine();
        }

        Console.Write("Enter the lastname of the employee to update: ");
        string? lastName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(lastName))
        {
            Console.Write("Last name cannot be empty. Please enter a valid last name: ");
            lastName = Console.ReadLine();
        }

        Employee? employee = employees.FirstOrDefault(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
        if (employee != null)
        {
            Console.Write("Enter new salary: ");
            decimal newSalary;
            while (!decimal.TryParse(Console.ReadLine(), out newSalary))
            {
                Console.Write("Invalid input. Please enter a valid salary: ");
            }
            employee.Salary = newSalary;
            Console.WriteLine("~ Salary updated successfully. ~");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }


    static void DeleteEmp()
    {
        Console.Write("Enter the firstname of the employee to delete: ");
        string? firstName = Console.ReadLine();

        Console.Write("Enter the lastname of the employee to delete: ");
        string? lastName = Console.ReadLine();

        Console.WriteLine();

        Employee? employee = employees.FirstOrDefault(e => 
        e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
        e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine("~ Employee deleted successfully. ~");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}   