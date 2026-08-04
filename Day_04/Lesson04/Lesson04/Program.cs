using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Program
    {
        enum Team2
        {
            Ajmal = 21,
            Rohini,
            Shanthi,
            Rajan = 26,
            Sonali,
            Clara,
            Kevin = 31,
            Prem
        }

        static void Main(string[] args)
        {
            // 1. 
            // Enum
            // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
            // enum has fixed set of constants
            // To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma
            // Enum constants has default values which starts from 0 and incremented to one by one. But we can change the default value. (like as 10, 5 .. etc)

            // print the enum elements
            Console.WriteLine(Team1.Kamal); // same name
            Console.WriteLine((int)Team1.Kamal); // index of the constant

            // GetName()
            Console.WriteLine(Enum.GetName(typeof(Team2), 23));
            
            // looping
            foreach(string name in Enum.GetNames(typeof(Team1)))
            {
                Console.Write($"{name} ");
                //Console.Write(name + "  ");
            }
            Console.WriteLine();

            // display the index
            foreach (int index in Enum.GetValues(typeof(Team2)))
            {
                Console.Write($"{index} ");
            }

            Console.WriteLine();
           
            // display the values
            foreach (Team2 index in Enum.GetValues(typeof(Team2)))
            {
                Console.Write($"{index} ");
            }

            // 2.
            // StringBuilder
            // StringBuilder allows you to modify the contents of the string without creating a new object
            // Common Methods of StringBuilder:
            // Append: Adds text to the end of the current StringBuilder object.
            // Insert: Inserts text at a specified index.
            // Remove: Removes a range of characters.
            // Replace: Replaces all occurrences of a character or string with another character or string.
            // ToString: Converts the StringBuilder to a string.
            
            
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World!");

            Console.WriteLine(sb.ToString());  // Output: Hello World!

            // Insert a string at a specific index
            sb.Insert(6, "beautiful ");
            Console.WriteLine(sb.ToString());  // Output: Hello beautiful World!

            // Remove a range of characters
            sb.Remove(6, 10);  // Remove "beautiful "
            Console.WriteLine(sb.ToString());  // Output: Hello World!

            // Replace a string
            sb.Replace("World", "C#");
            Console.WriteLine(sb.ToString());  // Output: Hello C#!

            // 3.
            // Exception Handling
            // The try statement allows you to define a block of code to be tested for errors while it is being executed.
            // The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            // The finally statement lets you execute code, after try...catch, regardless of the result
            try
            {
                // Divide by zero exception
                int x = 10;
                Console.WriteLine($"10/0 = {x / 0}");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception e)
            {
                Console.WriteLine(e);
                //Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This block always run");
            }

            // 4.
            // can we create more than one class with same name??

            // partial classes allow you to split the definition of a class across multiple files. 
            // All parts of the partial class must share the same name and be marked with the partial keyword. 
            // When compiled, the C# compiler combines all the partial class parts into a single class definition.

            // create Person partial class named as PersonPart1.cs and PersonPart2.cs
            // create the person object
            Person p = new Person();

            p.FirstName = "Ravi";
            p.LastName = "Raj";
            p.Age = 21;

            p.DisplayFullName();
            p.DisplayAge();

            /*
            Suppose you're working on a large project and you have a class named Employee that needs to handle personal information and job-related details. 
                One file for personal information (like FirstName, LastName, and DisplayFullName() method).
                Another file for job-related information (like Position, Salary, and DisplayJobDetails() method). 
            */

            Employee employee = new Employee
            {
                FirstName = "Kamal",
                LastName = "Dasan",
                Position = "Software Engineer",
                Salary = 85000
            };

            employee.DisplayFullName();     // Output: Jane Doe
            employee.DisplayJobDetails();   // Output: Position: Software Engineer, Salary: 85000

            // 5.
            // Nullable
            // nullable types allow you to assign null to value types like int, double, bool, etc., which cannot normally be null.
            // To create a nullable type, you can either use the Nullable<T> generic type or 
            // the shorthand syntax by appending a ? after the value type (e.g., int?, bool?)
            Nullable<int> n1 = null;
            // try this -> int n2 = null;
            int? n2 = null;

            // in the nullable we can assign values as well
            int? n3 = 23;
            Nullable<int> n4 = 45;

            double? n6 = 34.5;

            Console.WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}, n4 = {n4}, n6 = {n6}");

            // Question
            // You are designing a program to handle optional data from a user. 
            // The user may or may not provide their age, and the system must check whether the age has been entered. Write a C# program that:
            // Accepts a nullable integer for the user's age.
            // If the age is provided, print it; otherwise, print "Age is not provided."
            // Use the null - coalescing operator to ensure that if the age is not entered, it defaults to 18.

            int? userAge = null;

            if (userAge.HasValue)
            {
                Console.WriteLine($"Age: {userAge.Value}");
            }
            else
            {
                Console.WriteLine("Age is not provided.");
            }

            // Use null-coalescing operator to default to 18 if null
            int displayedAge = userAge ?? 18;
            Console.WriteLine($"Displayed Age: {displayedAge}");

            Console.ReadKey();
        }

        enum Team1
        {
            Ram = 3,
            Kamal,
            Jana,
            Rose = 11,
            Srinisha,
            Bandara = 14,
            Sameera
        }

        
    }
}
