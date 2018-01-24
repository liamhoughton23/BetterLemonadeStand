using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Sugar : Items
    {
        public double priceOf8CupsSugar;
        public double priceOf20CupsSugar;
        public double priceOf48CupsSugar;

        public Sugar()
        {
            priceOf8CupsSugar = 0.50;
            priceOf20CupsSugar = 1.59;
            priceOf48CupsSugar = 3.42;
        }
        public override string GetName()
        {
            name = "Sugar";
            return name;
        }
        public void DisplayPriceOfSugar()
        {
            UI.DisplayMessage("8 Cups of Sugar: " + priceOf8CupsSugar);
            UI.DisplayMessage("20 Cups of Sugar: " + priceOf20CupsSugar);
            UI.DisplayMessage("48 Cups of Sugar: " + priceOf48CupsSugar);
        }  
    }
}
