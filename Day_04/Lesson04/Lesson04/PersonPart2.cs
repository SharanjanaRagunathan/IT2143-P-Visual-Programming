using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    public partial class Person
    {
        public int Age { get; set; }

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
}
