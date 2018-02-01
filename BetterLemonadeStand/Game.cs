using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Game
    {
        //member variables 
        string welcome;
        string rules;
        Day day;
        Weather weather;
        Store store;
        Player player;

        //constructor
        public Game()
        {
            welcome = "Welcome to Lemonade Stand!";
            rules = "The goal of the game is to make as much profit from selling lemonade as possible. The weather will affect how much people want lemonade, so price it accordingly. You start with $20.00";
            day = new Day();
            weather = new Weather();
            store = new Store();
            player = new Player();
        }

        //member methods
        public void DisplayRules()
        {
            UI.DisplayMessage(welcome);
            UI.DisplayMessage(rules);
        }

        public void PlayGame()
        {
            DisplayRules();
            day.DisplayDays(1);
            weather.gettingForecast();
            weather.gettingTemp();
            store.DisplayingStoreInfo();
            store.SelectingTypeOfItem();
            player.displayInventory();

        }
    }
}
