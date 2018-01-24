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

        //constructor
        public Game()
        {
            welcome = "Welcome to Lemonade Stand!";
            rules = "The goal of the game is to make as much profit from selling lemonade as possible. The weather will affect how much people want lemonade, so price it accordingly. You start with $20.00";
        }

        //member methods
        public void DisplayRules()
        {
            UI.DisplayMessage(welcome);
            UI.DisplayMessage(rules);
        }
    }
}
