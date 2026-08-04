using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    public struct Circle
    {
        // prop, double Tab -> to create properties

        //---- Constructors
        // ctor, double Tab -> to create constructors
        // cannot create default constructors
        // Only create parameterized constructors

        public double Radius { get; set; }

        // Constructor that takes a double
        public Circle(double rd)
        {
            this.Radius = rd;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
			//return PI * Math.Pow(Radius, 2);
        }

        // Method to compare areas of two circles
        public bool IsLargerThan(Circle other)
        {
            return this.Area() > other.Area();
        }
    }
}
