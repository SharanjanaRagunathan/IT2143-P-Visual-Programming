using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    public partial class Employee
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public void DisplayJobDetails()
        {
            Console.WriteLine($"Position: {Position}, Salary: {Salary}");
        }
    }
}
