using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPro1
{
    // in outside the class also possible

    // Define a delegate that takes a string argument and returns void 
    // public delegate void PrintMessage(string message);

    class Program
    {
        // Define a delegate that takes a string argument and returns void
        public delegate void PrintMessage(string message);

        // Method 1 matching the delegate signature
        public static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }

        // Method 2 matching the delegate signature
        public static void PrintUpperCase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        static void Main(string[] args)
        {
            // Delegates
            // A delegate in C# is a type that represents references to methods with a specific parameter list and return type. 
            // In simpler terms, a delegate is like a pointer to a function.

            // part 01
            // 1. Creating a delegate (can create any where outside or inside of the class but outside of main method)

            // 2. Create a delegate instance 
            PrintMessage obj;

            // 3. Assign the PrintToConsole method
            obj = PrintToConsole;
            obj("Hello, World!");

            // 4. Change the delegate target to PrintUpperCase method
            obj = PrintUpperCase;
            obj("Hello, World!");

            // 5. Multicasting - Calling both methods in sequence
            obj += PrintToConsole;
            obj("Delegates in C#");

            // Another way
            //PrintMessage obj = new PrintMessage(PrintToConsole);
            //PrintMessage obj1 = new PrintMessage(PrintUpperCase);

            //obj("Hello");
            //obj1("welcome");

            // Delegates Multicasting
            // Composing delegate objects using "+" operator
            // Only same type delegates can be composed
            //PrintMessage ob;
            //ob = obj;
            //ob += obj1;

            //ob("welcome home");

            Console.ReadKey();
        }
    }
}
