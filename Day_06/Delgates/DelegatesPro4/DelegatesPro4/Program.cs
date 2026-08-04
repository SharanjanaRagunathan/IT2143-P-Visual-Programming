using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPro4
{
    delegate int NumberChanger(int n);
    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            /*
            Delegates Multicasting
            
            Composing delegate objects using "+" operator
            Only same type delegates can be composed 
            */

            // Create objects for delegate
            NumberChanger ob;
            NumberChanger ob1 = new NumberChanger(AddNum);
            NumberChanger ob2 = new NumberChanger(MultNum);

            ob = ob1;
            ob += ob2;

            // Calling methods using delegate objects
            ob(34);
            Console.WriteLine("Value of Num: {0}", GetNum());

            Console.ReadKey();
        }
    }
}
