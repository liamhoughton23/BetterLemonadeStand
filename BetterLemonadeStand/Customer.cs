using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Customer
    {
        //member variables 
        Random random;
        int numberOfCustomersBuy;
        public int customerNumber;

        //constructor


        //member methods
        public int GettingInitialNumber()
        {
            random = new Random();
            customerNumber = random.Next(0, 19);
            return customerNumber;
        }
    }
}
