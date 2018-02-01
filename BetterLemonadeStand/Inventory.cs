using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Inventory
    {
        //member variables 
        public List<int> storingLemons;
        public List<int> storingCups;
        public List<int> storingSugar;
        public List<int> storingIceCubes; 
        //constructor
        public Inventory()
        {
            storingLemons = new List<int>();
            storingCups = new List<int>();
            storingSugar = new List<int>();
            storingIceCubes = new List<int>();
        }

        //member methods
        public void AddingLemons(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Lemons Lemons = new Lemons();
                storingLemons.Add(1);
            }
        }

        public void AddingCups(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Cups Cups = new Cups();
                storingCups.Add(1);
            }
        }

        public void AddingSugar(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Sugar Sugar = new Sugar();
                storingSugar.Add(1);
            }
        }

        public void AddingIceCubes(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                IceCubes IceCubes = new IceCubes();
                storingIceCubes.Add(1);
            }
        }

        public void displayInventory()
        {
            string displayI = "This is your full inventory: ";
            string displayLemons = "Lemons : ";
            string displayCups = "Cups : ";
            string displaySugar = "Sugar: ";
            string displayIceCubes = "Ice Cubes: ";
            UI.DisplayMessage(displayI);
            UI.DisplayMessage(displayLemons + storingLemons.Count);
            UI.DisplayMessage(displayCups + storingCups.Count);
            UI.DisplayMessage(displaySugar + storingSugar.Count);
            UI.DisplayMessage(displayIceCubes + storingIceCubes.Count);
        }
        /*
        public void CheckingInventoryLemons(Recipe recipe)
        {
            if (recipe.numberOfLemonsPerPitcher < storingLemons.Count)
            {
                RemoveLemons(recipe);
            }
            else
            {
                Console.WriteLine("You don't have enough to add that to your pitcher.");
                recipe.GetLemonsPitcher();
            }
        }

        public void CheckingInventorySugar(Recipe recipe)
        {
            if (recipe.numberOfLemonsPerPitcher < storingSugar.Count)
            {
                RemoveLemons(recipe);
            }
            else
            {
                Console.WriteLine("You don't have enough to add that to your pitcher.");
                recipe.GettingSugarPitcher();
            }
        }

        public void CheckingInventoryIceCubes(Recipe recipe)
        {
            if (recipe.amountOfIcePerCup < storingIceCubes.Count)
            {
                RemoveIceCubes(recipe);
            }
            else
            {
                Console.WriteLine("You don't have enough to add that amount of ice to your cup.");
                recipe.GettingIcePerCup();
            }
        }
        public void RemoveCups(Recipe recipe)
        {
            if (storingCups.Count == 0)
            {
                Console.WriteLine("you don't have any more cups.");
            }
            else
            {
                storingCups.Remove(1);
            }
        }
        public void RemoveLemons(Recipe recipe)
        {
            for (int i = 0; i < recipe.numberOfLemonsPerPitcher; i++)
            {
                storingLemons.Remove(i);
            }
        }
        public void RemoveSugar(Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfSugarPerPitcher; i++)
            {
                storingSugar.Remove(i);
            }
        }
        public void RemoveIceCubes(Recipe recipe)
        {
            for (int i = 0; i < recipe.amountOfIcePerCup; i++)
            {
                storingLemons.Remove(i);
            }
        }
*/

    }
}
