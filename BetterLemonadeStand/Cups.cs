using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Cups : Items
    {
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;

        public Cups()
        {
            priceOf25Cups = 0.96;
            priceOf50Cups = 1.70;
            priceOf100Cups = 3.04;
        }
        public override string GetName()
        {
            name = "Cups";
            return name;
        }
        public void DisplayPriceOfCups()
        {
            UI.DisplayMessage("25 cups: " + priceOf25Cups);
            UI.DisplayMessage("50 cups: " + priceOf50Cups);
            UI.DisplayMessage("100 cups: " + priceOf50Cups);
        }
    }
}
