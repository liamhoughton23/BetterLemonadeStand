using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class IceCubes : Items
    {
        public double priceOf100IceCubes;
        public double priceOf250IceCubes;
        public double priceOf500IceCubes;

        public IceCubes()
        {
            priceOf100IceCubes = 0.96;
            priceOf250IceCubes = 2.07;
            priceOf500IceCubes = 3.91;
        }
        public override string GetName()
        {
            name = "Ice Cubes";
            return name;
        }
        public void DisplayPriceOfIceCubes()
        {
            UI.DisplayMessage("100 Ice Cubes: " + priceOf100IceCubes);
            UI.DisplayMessage("250 Ice Cubes: " + priceOf250IceCubes);
            UI.DisplayMessage("500 Ice Cubes: " + priceOf500IceCubes);
        }
    }
}
