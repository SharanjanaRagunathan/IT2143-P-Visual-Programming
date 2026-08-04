using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using StringLibrary;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. DLL Files
            // A DLL (Dynamic Link Library) file in C# is a compiled library that contains code and data that can be used by multiple programs simultaneously. 
            // The main advantage of a DLL is code reusability, 
            // 01. Create class library (.NET Framework) to create DLL files
            // 02. Build the project
            // 03. Now use the DLL file using references. 
            // to use the references right click on references -> select add reference -> select browse -> choose browse -> locate the DLL file -> select the file
            // 04. Import or use the DLL file before the namespace 
            // 05. Now import and use the classes or methods defined in the DLL
            
            // 06. create an object of the MathLibrary 
            Class1 calc = new Class1();
            // anotherway
            //MathLibrary.Class1 cal = new MathLibrary.Class1();

            // 07. call te methods
            int result1 = calc.Add(5, 10);
            int result2 = calc.Multiply(4, 6);

            // 08. display the output
            Console.WriteLine($"Addition: {result1}");    // Output: Addition: 15
            Console.WriteLine($"Multiplication: {result2}");  // Output: Multiplication: 24

            // Question
            /*
             * build a DLL that performs basic string operations, such as reversing a string and converting a string to uppercase. 
             * Write the following:
                * A C# class library (StringLibrary.dll) containing methods to reverse a string and convert it to uppercase.
                * A console application that uses this DLL to read a string from the user, reverse it, convert it to uppercase, and display the results.
            */

            StringOperations strOps = new StringOperations();

            // Input from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Reverse the string
            string reversed = strOps.Reverse(input);
            Console.WriteLine($"Reversed: {reversed}");

            // Convert to uppercase
            string uppercased = strOps.ToUppercase(input);
            Console.WriteLine($"Uppercase: {uppercased}");


            Console.ReadKey();

        }
    }
}
