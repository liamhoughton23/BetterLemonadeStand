using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Recipe
    {
        //member variables 

        public int amountLemonsPerPitcher;
        public int amountSugarPerPitcher;
        public int amountOfIcePerCup;
        public string lemonsInput;
        public string priceInput;
        public string icePerCupInput;
        public string sugarInput;
        public double price;

        public double GettingPrice()
        {
            UI.DisplayMessage("What do you want the price of your lemonade to be set at?");
            priceInput = UI.GetInput();
            try
            {
                price = Convert.ToDouble(priceInput);
            }
            catch (Exception)
            {
                UI.DisplayMessage("You typed in something wrong, try again.");
                GettingPrice();
            }
            return price;
        }
        public int GetLemonsPerPitcher()
        {
            UI.DisplayMessage("How many lemons do you want per pitcher?");
            lemonsInput = UI.GetInput();
            try
            {
                amountLemonsPerPitcher = Convert.ToInt32(lemonsInput);
            }
            catch (Exception)
            {
                UI.DisplayMessage("You typed in something wrong, try again.");
                GetLemonsPerPitcher();
            }
            return amountLemonsPerPitcher;

        }
        public int GetSugarPitcher()
        {
            UI.DisplayMessage("How many cups of suagr do you want to use per pitcher?");
            sugarInput = UI.GetInput();
            try
            {
                amountSugarPerPitcher = Convert.ToInt32(sugarInput);
            }
            catch (Exception)
            {
                UI.DisplayMessage("You typed in something wrong, try again.");
                GetSugarPitcher();
            }
            return amountSugarPerPitcher;
        }
        public int GetIcePerCup()
        {
            UI.DisplayMessage("How many ice cubes do you want per cup?");
            icePerCupInput = UI.GetInput();
            try
            {
                amountOfIcePerCup = Convert.ToInt32(icePerCupInput);
            }
            catch (Exception)
            {
                UI.DisplayMessage("You typed in something wrong, try again.");
                GetIcePerCup();
            }
            return amountOfIcePerCup;
        }
    }
}
