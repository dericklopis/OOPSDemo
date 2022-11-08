using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO.Abstraction
{
    internal class Square : Shape
    {
        private int side;

        //method of square class 
        public Square(int x)
        {
            side = x;

        }

        // overriding of the abstract method of Shape 
        // class using the override keyword
        //public abstract void Area()
        public override void Area()
        {
            Console.Write("Area of Square: ");
            Console.WriteLine(side*side);
        }
    }
}
