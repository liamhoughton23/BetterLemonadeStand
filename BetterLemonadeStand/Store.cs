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
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;
        public double priceOf10Lemons;
        public double priceOf30Lemons;
        public double priceOf75Lemons;
        public double priceOf100IceCubes;
        public double priceOf250IceCubes;
        public double priceOf500IceCubes;
        public double priceOf8CupsSugar;
        public double priceOf20CupsSugar;
        public double priceOf48CupsSugar;
        public string whatTheyBought;
        Player player;
        public int numberOfItemsBought;


        //constructor
        public Store()
        {
            costOfLemons = "If you want to know the price of lemons, type 'lemons'";
            costOfCups = "If you want to know the price of cups, type 'cups'";
            costOfSugar = "If you want to know the price of sugar, type 'sugar'";
            costOfIceCubes = "If you want to know the price of ice cubes, type 'ice cubes'";
            priceOf25Cups = 0.96;
            priceOf50Cups = 1.70;
            priceOf100Cups = 3.04;
            priceOf100IceCubes = 0.96;
            priceOf250IceCubes = 2.07;
            priceOf500IceCubes = 3.91;
            priceOf10Lemons = 0.98;
            priceOf30Lemons = 2.23;
            priceOf75Lemons = 4.12;
            priceOf8CupsSugar = 0.50;
            priceOf20CupsSugar = 1.59;
            priceOf48CupsSugar = 3.42;
            player = new Player();
        }

        //member methods
        public void DisplayingStoreInfo()
        {
            storeInfo = "This is the Store, you will be brought here at the beginning of each day.";
            UI.DisplayMessage(storeInfo);
        }
        public void SelectingTypeOfItem()
        {
            UI.DisplayMessage(costOfLemons);
            UI.DisplayMessage(costOfIceCubes);
            UI.DisplayMessage(costOfSugar);
            UI.DisplayMessage(costOfCups);
            option = UI.GetInput();
            switch (option)
            {
                case "lemons":
                    DisplayPriceOfCups();
                    break;
                case "ice cubes":
                    DisplayPriceOfIceCubes();
                    break;
                case "sugar":
                    DisplayPriceOfSugar();
                    break;
                case "cups":
                    DisplayPriceOfCups();
                    break;
                default:
                    UI.DisplayMessage("you typed in something wrong");
                    DisplayingStoreInfo();
                    break;
            }

        }
        public void DisplayPriceOfCups()
        {
            UI.DisplayMessage("25 cups: " + priceOf25Cups);
            UI.DisplayMessage("50 cups: " + priceOf50Cups);
            UI.DisplayMessage("100 cups: " + priceOf50Cups);
            UI.DisplayMessage("Type in the number of cups you want");
            whatTheyBought = UI.GetInput();
            switch(whatTheyBought)
            {
                case "25":

                    break;
            }
        }

        public void DisplayPriceOfIceCubes()
        {
            UI.DisplayMessage("100 cubes: " + priceOf100IceCubes);
            UI.DisplayMessage("250 cubes: " + priceOf250IceCubes);
            UI.DisplayMessage("500 cubes: " + priceOf500IceCubes);
            UI.DisplayMessage("Type in the number of cups you want");
            whatTheyBought = UI.GetInput();
            try
            {
                if (whatTheyBought == "100")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("youo bought 100 cups");
                }
                else if (whatTheyBought == "250")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 250 cups");
                }
                else if (whatTheyBought == "500")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 500 cups");
                }
            }
            catch
            {
                Console.WriteLine("You typed in something wrong, try again.");
                DisplayPriceOfCups();
            }
        }
        public void DisplayPriceOfSugar()
        {
            UI.DisplayMessage("8 cups: " + priceOf8CupsSugar);
            UI.DisplayMessage("20 cups: " + priceOf20CupsSugar);
            UI.DisplayMessage("48 cups: " + priceOf48CupsSugar);
            UI.DisplayMessage("Type in the number of cups of sugar you want");
            whatTheyBought = UI.GetInput();
            try
            {
                if (whatTheyBought == "8")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("you bought 8 cups of sugar.");
                }
                else if (whatTheyBought == "20")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 50 cups of suagr");
                }
                else if (whatTheyBought == "48")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 100 cups of sugar");
                }
            }
            catch
            {
                Console.WriteLine("You typed in something wrong, try again.");
                DisplayPriceOfCups();
            }
        }
        public void DisplayPriceOfLemons()
        {
            UI.DisplayMessage("10 lemons: " + priceOf10Lemons);
            UI.DisplayMessage("30 lemons: " + priceOf30Lemons);
            UI.DisplayMessage("75 cups: " + priceOf75Lemons);
            UI.DisplayMessage("Type in the number of lemons you want");
            whatTheyBought = UI.GetInput();
            try
            {
                if (whatTheyBought == "10")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 10 leomns");
                }
                else if (whatTheyBought == "30")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 30 lemons");
                }
                else if (whatTheyBought == "75")
                {
                    player.buyingStuff(numberOfItemsBought);
                    UI.DisplayMessage("You bought 75 lemons");
                }
            }
            catch
            {
                Console.WriteLine("You typed in something wrong, try again.");
                DisplayPriceOfCups();
            }
        }
        public void BuyingMore()
        {

            UI.DisplayMessage("Do you want to buy more? This is what you have: ");
            player.displayInventory();
            UI.DisplayMessage("Type 'yes' or 'no'");
            option = UI.GetInput();
            switch (option)
            {
                case "yes":
                    UI.DisplayMessage("Type in what you want to buy more of");
                    SelectingTypeOfItem();
                    break;
                case "no":
                    UI.DisplayMessage("Total inventory:");
                    player.displayInventory();
                    break;
                default:
                    UI.DisplayMessage("Oops, typed in something wrong.");
                    BuyingMore();
                    break;



            }
        }
    }
}
