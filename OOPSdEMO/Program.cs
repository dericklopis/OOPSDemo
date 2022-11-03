using OOPSdEMO.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one program from below options");
            Console.WriteLine("1:Inheritance\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Animal animal = new Animal();
                    animal.Sleep();
                    lion lion = new lion();
                    lion.name ="lion";
                    Console.WriteLine("Name: "+ lion.name);
                    break;
                default:
                    Console.WriteLine("Please choose numbers within range");
                    break;
            }
        }
    }
}
