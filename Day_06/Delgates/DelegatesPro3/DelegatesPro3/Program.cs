using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPro3
{
    class Program
    {
        // create a delegate
        public delegate void Hello(string msg);

        // Create a method for a delegate
        // This method simply displays the string that it receives as a parameter
        public static void MyMessage(string mymsg)
        {
            Console.WriteLine(mymsg);
        }

        // Delegate as a parameter
        // Inside the method, the sum of n1 and n2 is calculated, and a message in the form of "The number is: (sum)" is passed to the delegate (delMsg).
        // The delegate is then used to call the method it's pointing to (in this case, MyMessage), which will print the message.
        public static void MethodParam(int n1, int n2, Hello delMsg)
        {
            delMsg("The number is: " + (n1 + n2).ToString());
        }

        static void Main(string[] args)
        {
            // Quiz: students need to understand by themself

            // inside the main
            Hello msg = MyMessage;  // Assign the MyMessage method to the Hello delegate
            MethodParam(1, 2, msg); // Pass the delegate and two integers to the MethodParam method

            Console.ReadKey();
        }
    }
}
