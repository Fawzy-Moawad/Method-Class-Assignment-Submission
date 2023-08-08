using System;

namespace MathOperationApp
{
    // Step 1: Create a class
    public class MathOperation
    {
        // Step 2: Create a void method with two integer parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (for example, adding 10)
            int result = firstNumber + 10;

            // Display the second integer on the screen
            Console.WriteLine($"Second Number: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 3: Instantiate the class
            MathOperation mathOperation = new MathOperation();

            // Step 4: Call the method in the class, passing in two numbers
            mathOperation.PerformMathOperation(5, 20);

            // Step 5: Call the method in the class, specifying the parameters by name
            mathOperation.PerformMathOperation(firstNumber: 8, secondNumber: 15);
        }
    }
}
