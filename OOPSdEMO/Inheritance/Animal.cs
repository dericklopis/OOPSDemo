using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO.Inheritance
{
    public class Animal
    {
        public string name;
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public virtual void Run()
        {
            Console.WriteLine("Depends on child");
        }
    }
}
