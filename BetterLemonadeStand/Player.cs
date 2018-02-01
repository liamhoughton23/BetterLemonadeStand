using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Player
    {
        //member variables 
        public double Money;
        public int numberOfItemsBought;
        Wallet wallet;
        Inventory inventory;

        //constructor
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
            numberOfItemsBought = 0;
            Money = 20.00;
        }

        //member methods
        public double buyingStuff(double price)
        {
            wallet.ValidatingFunds(price);
            Money -= price;
            return Money;
        }
        public void displayInventory()
        {
            string displayI = "This is your full inventory: ";
            string displayLemons = "Lemons : ";
            string displayCups = "Cups : ";
            string displaySugar = "Sugar: ";
            string displayIceCubes = "Ice Cubes: ";
            UI.DisplayMessage(displayI);
            UI.DisplayMessage(displayLemons + inventory.storingLemons.Count);
            UI.DisplayMessage(displayCups + inventory.storingCups.Count);
            UI.DisplayMessage(displaySugar + inventory.storingSugar.Count);
            UI.DisplayMessage(displayIceCubes + inventory.storingIceCubes.Count);
        }

    }
}
