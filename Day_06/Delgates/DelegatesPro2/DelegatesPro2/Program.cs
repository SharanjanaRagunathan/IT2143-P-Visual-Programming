using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPro2
{
    class Program
    {
        // Answer for the math operation question
        // Define a delegate that takes two integers and returns an integer
        public delegate int MathOperation(int x, int y);

        // Method to add two integers
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to multiply two integers
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        static void Main(string[] args)
        {
            // Question 
            // Write a program that defines a delegate called MathOperation which references methods that take two integers as parameters and return an integer.
            // Implement two methods:
            // Add - Adds two integers.
            // Multiply - Multiplies two integers. 
            // In the main method, demonstrate using the delegate to perform addition and multiplication, 
            // and show how to use the delegate for both single and multi - cast scenarios.
            // Single-cast delegate: Reference the Add method

            MathOperation operation;
            operation = Add;
            Console.WriteLine($"Addition: {operation(3, 4)}");  // Output: 7

            // Single-cast delegate: Reference the Multiply method
            operation = Multiply;
            Console.WriteLine($"Multiplication: {operation(3, 4)}");  // Output: 12

            // Multicast delegate: Invoke both Add and Multiply
            operation = Add;
            operation += Multiply;  // Multicasting
            Console.WriteLine($"Multicast - Last method result: {operation(3, 4)}");  // Output: 12

            Console.ReadKey();
        }
    }
}
