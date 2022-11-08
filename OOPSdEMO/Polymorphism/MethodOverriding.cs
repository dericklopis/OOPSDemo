using OOPSdEMO.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO.Polymorphism
{
    internal class MethodOverriding
    {
        class Tiger : Animal
        {
            public override void Run()
            {
                Console.WriteLine("Running fast");
            }
        }
        
    }
}
