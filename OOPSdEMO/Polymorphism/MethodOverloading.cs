using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO.Polymorphism
{
    public class MethodOverloading
    {
        public void Addition(int first, int second)
        {
            Console.WriteLine(first+second);
        }
        //differing number of parameters
        public void Addition(int first, int second, int third)
        {
            Console.WriteLine(first + second + third);
        }
        //changing datatype
        public void Addition(float first, float second, int third)
        {
            Console.WriteLine(first + second + third);
        }
        //order of datatype
        public void Addition(int third, float first, float second)
        {
            Console.WriteLine(first + second + third);
        }
    }
}
