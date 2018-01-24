using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Store
    {
        //member variables 
        public double cost;
        string option;
        string storeInfo;
        string costOfLemons;
        string costOfCups;
        string costOfIceCubes;
        string costOfSugar;


        //constructor
        public Store()
        {
            costOfLemons = "If you wan to know the price of lemons, type 'lemons'";
            costOfCups = "If you want to know the price of cups, type 'cups'";
            costOfSugar = "If you want to know the price of sugar, type 'sugar'";
            costOfIceCubes = "If you want to know the price of ice cubes, type 'ice cubes'";

        }

        //member methods
        public void DisplayingStoreInfo()
        {
            storeInfo = "This is the Store, you will be brought here at the beginning of each day.";
            UI.DisplayMessage(storeInfo);
        }
        public void SelectingTypeOfItem(Lemons lemons, Sugar sugar, IceCubes ice, Cups cups)
        {
            UI.DisplayMessage()
        }
    }
}
