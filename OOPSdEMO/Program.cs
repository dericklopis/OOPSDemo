using OOPSdEMO.Abstraction;
using OOPSdEMO.Inheritance;
using OOPSdEMO.Polymorphism;
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
            Console.WriteLine("1:Inheritance \n2:PolyMorphism \n3:Abstraction");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Animal animal = new Animal();
                    animal.Sleep();
                    lion lion = new lion();
                    lion.name ="lion";
                    Console.WriteLine("Name: "+ lion.name);
                    Console.ReadLine();
                    break;
                case 2:
                    MethodOverloading addition = new MethodOverloading();
                    addition.Addition(20, 10);
                    addition.Addition(10, 34.56f, 23.45f);
                    Animal animal1 = new Animal();
                    animal1.Run();
                    Console.ReadLine();
                    //Tiger tiger = new Tiger();
                    //tiger.Run();
                    break;
                case 3:
                    //creating reference of Shape class
                    //which refer to Square class instance
                    Square sh = new Square(7);
                    // calling the method
                    sh.Area();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please choose numbers within range");
                    break;
            }
        }

    }
}
