
namespace MathOperations
{
    // Define a class named MathClass
    class MathClass
    {
        // Define a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a mathematical operation (e.g., multiply by 2) on the first integer
            int result = num1 * 2;

            // Display the result of the operation
            Console.WriteLine("The result of the operation on the first number: " + result);

            // Display the second integer
            Console.WriteLine("The second number is: " + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathClass
            MathClass mathObj = new MathClass();

            // Call the method, passing in two numbers
            mathObj.PerformOperation(5, 10);

            // Call the method again, specifying parameters by name
            mathObj.PerformOperation(num1: 7, num2: 20);

            // Prevent console from closing immediately
            Console.ReadLine();
        }
    }
}
