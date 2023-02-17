using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        int option = 0;

        Console.WriteLine("Welcome to the Employee Record System!");

        do
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. Update employee details");
            Console.WriteLine("4. View all employees");
            Console.WriteLine("5. Exit");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter new employee's name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter new employee's department:");
                    string department = Console.ReadLine();
                    Console.WriteLine("\nEnter new employee's salary:");
                    double salary = double.Parse(Console.ReadLine());
                    Employee employee = new Employee { Name = name, Department = department, Salary = salary };
                    employees.Add(employee);
                    Console.WriteLine("\nEmployee added successfully.");
                    break;

                case 2:
                    Console.WriteLine("\nEnter employee's ID to remove:");
                    int id = int.Parse(Console.ReadLine());
                    employee = employees.Find(e => e.Id == id);

                    if (employee != null)
                    {
                        employees.Remove(employee);
                        Console.WriteLine("\nEmployee removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nEmployee not found.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nEnter employee's ID to update:");
                    id = int.Parse(Console.ReadLine());
                    employee = employees.Find(e => e.Id == id);

                    if (employee != null)
                    {
                        Console.WriteLine("\nEnter employee's new name (press enter to keep current name):");
                        name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(name))
                        {
                            employee.Name = name;
                        }

                        Console.WriteLine("\nEnter employee's new department (press enter to keep current department):");
                        department = Console.ReadLine();
                        if (!string.IsNullOrEmpty(department))
                        {
                            employee.Department = department;
                        }

                        Console.WriteLine("\nEnter employee's new salary (press enter to keep current salary):");
                        string newSalary = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newSalary))
                        {
                            employee.Salary = double.Parse(newSalary);
                        }

                        Console.WriteLine("\nEmployee details updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nEmployee not found.");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nAll employees:");
                    foreach (Employee e in employees)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Department: {2}, Salary: {3}", e.Id, e.Name, e.Department, e.Salary);
                    }
                    break;

                case 5:
                    Console.WriteLine("\nExiting program...");
                    break;

                default:
                    Console.WriteLine("\nInvalid option selected. Please try again.");
                    break;
            }

        } while (option != 5);

        Console.ReadKey();
    }
}
