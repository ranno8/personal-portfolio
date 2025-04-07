IQuittableDemo
using System; // Importing the System namespace to access Console and other essential utilities.

// Define an interface called IQuittable
interface IQuittable
{
    void Quit(); // Declare a method signature for Quit (no implementation here, just the method definition)
}

// Define an Employee class that implements the IQuittable interface
class Employee : IQuittable
{
    // Property to hold the employee's name
    public string Name { get; set; }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"Employee {Name} has quit the job.");
    }
}

// Main program class where the logic runs
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee and assign a name
        Employee employee = new Employee() { Name = "John Doe" };

        // Use polymorphism by creating an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method using the IQuittable interface reference
        quittableEmployee.Quit();

        // Pause the console to keep the window open for review
        Console.ReadLine();
    }
}
