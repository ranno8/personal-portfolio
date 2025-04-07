employee.cs
// Employee.cs
using System;

// Define the Employee class
class Employee
{
    // Properties for Employee details
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the '==' operator to compare Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Ensure neither object is null before comparing
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return ReferenceEquals(emp1, emp2); // Return true if both are null
        }
        return emp1.Id == emp2.Id; // Compare employee IDs
    }

    // Overload the '!=' operator (required to pair with '==')
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // Use the '==' logic for consistency
    }

    // Override Equals and GetHashCode for proper behavior in collections
    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return this.Id == employee.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}

// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects with sample data
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

        // Compare the Employee objects using the overloaded '==' operator
        if (emp1 == emp2)
        {
            Console.WriteLine("Both employees have the same ID and are considered equal.");
        }
        else
        {
            Console.WriteLine("Employees have different IDs and are not considered equal.");
        }

        // Demonstrate the '!=' operator
        if (emp1 != emp2)
        {
            Console.WriteLine("Employees are not the same.");
        }
        else
        {
            Console.WriteLine("Employees are the same.");
        }

        // Pause console for user to see results
        Console.ReadLine();
    }
}
