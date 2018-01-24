using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Lemons : Items
    {
        public double priceOf10Lemons;
        public double priceOf30Lemons;
        public double priceOf75Lemons;
        
        public Lemons()
        {
            priceOf10Lemons = 0.98;
            priceOf30Lemons = 2.23;
            priceOf75Lemons = 4.12;
        }
        public override string GetName()
        {
            name = "Lemons";
            return name;
        }
        public void DisplayPriceOfCups()
        {
            UI.DisplayMessage("10 lemons: " + priceOf10Lemons);
            UI.DisplayMessage("50 cups: " + priceOf30Lemons);
            UI.DisplayMessage("100 cups: " + priceOf75Lemons);
        }
    }
}
