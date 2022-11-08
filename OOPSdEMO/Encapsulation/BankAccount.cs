using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdEMO.Encapsulation
{
    internal class BankAccount
    {
        private long balance; //5045

        public long Amount
        {
            get
            {
                return balance;
            }
            set
            {
                if (value>0)
                    balance = value;
                else
                    Console.WriteLine("Balance should be greater than 0");
            }
        }
    }
}
