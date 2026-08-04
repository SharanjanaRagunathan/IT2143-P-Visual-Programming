using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    public struct Student
    {
        // type prop then press double tab
        // it will automatically creates the property 
        public string Name { get; set; }
        // its equals to our java getter and setter
        // here Set the Name property
        // stu.Name = "Alice";
        // When you access Name, the get accessor is called.

        // Get the Name property
        // Console.WriteLine(person.Name);  
        // Output: Alice
        // When you assign a value to Name, the set accessor is called.

        public string RegNo { get; set; }
        public int Age { get; set; }

        public Student(string name, string regno, int age)
        {
            this.Name = name;
            this.RegNo = regno;
            this.Age = age;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"{Name} {RegNo} {Age}");
        }
    }
}
