using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            // Class in different file
            // Right click on Lesson03 (on the right hand side) -> click Add -> 
            // select class file or new item then class file -> give class name
            // Calculator cal = new Calculator();
            // Console.WriteLine("Sum is : {0} ", cal.Add(5, 10));
            // delete the clss file

            // 2. 
            // Struct 
            // create a seperate struct file same as class file
            // then rename the class as struct
            Student st = new Student("ravi", "2021/IT/01", 23);
            st.ShowStudent();

            // 3. 
            // struct question
            /*
             Write a C# program using a struct Circle that contains:
                A field Radius to store the radius of the circle.
             Constructor:
                to initializes the radius with a given value.
             
             A method Area() that calculates and returns the area of the circle.
             A method IsLargerThan(Circle other) that returns true if the current circle's area is larger than the area of another circle.
             
             In the Main method:
                1. Create two instances of Circle, one using the constructor with a radius of 2 and another with a radius of 4.
                Print the area of both circles.
                2. Compare the circles using IsLargerThan() and print whether one circle is larger than the other.
             
             */
            Circle c1 = new Circle(2);
            Circle c2 = new Circle(4);
           
            Console.WriteLine($"Circle 1 Area: {c1.Area()}");
            Console.WriteLine($"Circle 2 Area: {c2.Area()}");

            // Compare the two circles' areas and print the result
            if (c2.IsLargerThan(c1))
            {
                Console.WriteLine("Circle 2 is larger than Circle 1");
            }
            else
            {
                Console.WriteLine("Circle 1 is larger than Circle 2");
            }

            // so 
            // variable - single element single data type
            // array - multiple elements single data type
            // struct - multiple elements multiple data type

            Console.ReadKey();
        }
    }
}
