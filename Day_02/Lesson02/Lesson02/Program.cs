using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Calculator
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to calculator program");
        }

        public int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Subtraction(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        public int Multiplication(int a, int b)
        {
            int mul = a * b;
            return mul;
        }

        public int Division(int a, int b)
        {
            if (b == 0)
            {
                return -1;
            }
            int div = a / b;
            return div;
        }
    }

    // rectangle class
    public class Rectangle
    {
        public int length;
        public int width;

        public int Perimeter()
        {
            int peri = 2 * (length + width);
            return peri;
        }

        public int Area()
        {
            int area = length * width;
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 
            // iterations
            // print the first 5 prime numbers (2,3,5,7,11)
            int n = 5;
            int counter = 0;
            int i = 2;
            while (counter < n)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    ++counter;
                    Console.WriteLine(i);
                }
                i++;
            }

            // loops with five keywords in the Jump Statements:
            // break
            for (int j = 0; j < 10; j++)
            {
                if (j > 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }

            // continue
            for (int k = 0; k < 10; k++)
            {
                if (k % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(k);
            }

            // goto
            for (int q = 0; q < 10; q++)
            {
                for (int m = 0; m < 10; m++)
                {
                    if (q == 5 && m == 5)
                    {
                        goto end;
                    }
                    Console.WriteLine(q + ", " + m);
                }
            }

            end:
            Console.WriteLine("Loop exited");

            // question
            /*
             Write a C# program using a nested for loop to print numbers from 1 to 10. Inside the loop:
             If the current number is divisible by 3, use the continue statement to skip printing that number and move to the next iteration of the outer loop.
             If the current number is 7, use the goto statement to skip all remaining iterations and jump to a labeled section where a message should be printed.
             If the current number is greater than 8, terminate the loop early using the break statement.
            */
            for (int p = 1; p <= 10; p++)
            {
                if (p % 3 == 0)
                {
                    continue; // Skip numbers divisible by 3
                }

                if (p == 7)
                {
                    goto LabelExit; // Jump to label when 7 is found
                }

                if (p > 8)
                {
                    break; // Terminate the loop if number is greater than 8
                }

                Console.WriteLine(p);
            }

            LabelExit:
                Console.WriteLine("7 detected, jumping out!");
                Console.WriteLine("End of loop.");

            Console.ReadKey();

            // Practice Question:
            // Write a C# program that asks the user to enter a password. The program should:
            // Allow a maximum of 3 attempts to enter the correct password "secret".
            // If the password is correct within 3 attempts, display "Authenticated" and stop asking.
            // If the password is incorrect, display "Not Authenticated" and show how many attempts are left.
            // If all 3 attempts are used and the password is still incorrect, display "Account Locked".

            string password;
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (password == "secret")
                {
                    Console.WriteLine("Authenticated");
                    break;
                }
                else
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        Console.WriteLine($"Not Authenticated. You have {attempts} attempts left.");
                        // Console.WriteLine("Not Authenticated. You have {attempts} attempts left.");
                        // the $ symbol in front of a string is used to enable string interpolation. 
                        // String interpolation allows you to embed variables or expressions inside a string in an easier and more readable way than traditional string concatenation.
                    }
                    else
                    {
                        Console.WriteLine("Not Authenticated. Account Locked.");
                    }
                }
            }


            // 2. 
            // handling classes and methods
            // create a class called calculator and do the basic calculator operations
            // create object
            Calculator cal = new Calculator();
            // cal lthe needed methods
            int x = 10;
            int y = 15;

            cal.Welcome();
            Console.WriteLine("The addition is : " + cal.Addition(x, y));
            Console.WriteLine("The subtraction is : "+ cal.Subtraction(x, y));
            Console.WriteLine("The multiplication is : "+ cal.Multiplication(x, y));

            if(cal.Division(x, y) == -1)
            {
                Console.WriteLine("The divisior must be grater than 0");
            }
            else
            {
                Console.WriteLine("The division is : " + cal.Division(x, y));
            }

            // 3. 
            // create a rectangle class and class instances to calculate perimeter and area. 
            // allow user to input length and width. calculate perimeter and area and display it
            Rectangle rect = new Rectangle();

            Console.Write("Enter the length of the rectangle : ");
            string l = Console.ReadLine();
            int rl = Int32.Parse(l);

            Console.Write("Enter the width of the rectangle : ");
            string w = Console.ReadLine();
            int rw = Int32.Parse(w);

            rect.length = rl;
            rect.width = rw;

            Console.WriteLine("The perimeter of the rectangle is : " + rect.Perimeter());
            Console.WriteLine("The area of the rectangle is : " + rect.Area());

            // 4. 
            // C# Arrays
            // To declare an array, define the variable type with square brackets:
            string[] fruits;

            // Create an array of four elements, and add values later
            // string[] fruits = new string[5];
            //fruits[0] = "apple";
            //fruits[1] = "banana";
            //fruits[2] = "mango";
            //fruits[3] = "orange";
            //fruits[4] = "berry";

            // Create an array of five elements and add values right away 
            // string[] fruits = new string[5] { "apple", "banana", "mango", "orange", "berry" };

            // Create an array of five elements without specifying the size 
            // string[] fruits = new string[] { "apple", "banana", "mango", "orange", "berry" };

            // Create an array of five elements, omitting the new keyword, and without specifying the size
            // string[] fruits = { "apple", "banana", "mango", "orange", "berry" };

            // Console.WriteLine(fruits[1]);

            // array with loop
            //for (int z = 0; z < fruits.Length; z++)
            //{
            //    Console.WriteLine(fruits[z]);
            //}

            // foreach to display array elements
            //foreach (string f in fruits)
            //{
            //    Console.WriteLine(f + " ");
            //}

            // sort the array elements
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string cr in cars)
            {
                Console.WriteLine(cr);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int num in myNumbers)
            {
                Console.WriteLine(num);
            }

            // Write a manual way to find the sum and maximum
            int sum = 0;

            //for (int r = 0; r < numbers.Length; r++)
            //{
            //    sum += numbers[r];
            //}

            //Console.WriteLine(sum);


            int max = 0;

            //for (int u = 0; u < numbers.Length; u++)
            //{
            //    if (max < numbers[u])
            //    {
            //        max = numbers[u];
            //    }
            //}

            //Console.WriteLine(max);

			// using System.Linq;
            // Min, Max, and Sum, can be found in the System.Linq
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // Question
            // Write a C# program that defines a 3x3 two-dimensional array (matrix) to store integer values. The program should:
            // Initialize the array with predefined values.
            // Use a loop to check each element of the array:
            // If the element is an even number, print "Even: <value>".
            // If the element is an odd number, print "Odd: <value>".

            // 3x3 two-dimensional array
            int[,] matrix = {
                { 2, 7, 5 },
                { 4, 3, 6 },
                { 1, 8, 9 }
            };

            // Loop through each element in the 2D array
            for (int g = 0; g < 3; g++)
            {
                for (int h = 0; h < 3; h++)
                {
                    // Check if the number is even or odd
                    if (matrix[g, h] % 2 == 0)
                    {
                        Console.WriteLine($"Even: {matrix[g, h]}");
                    }
                    else
                    {
                        Console.WriteLine($"Odd: {matrix[g, h]}");
                    }
                }
            }

            // Handling 2d array
            int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int e=0; e<arr.GetLength(0); e++) // 0 for rows
            {
                for(int f=0; f<arr.GetLength(1); f++) // 1 for columns
                {
                    Console.WriteLine("{0} ", arr[e, f]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
