using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Wallet
    {
        //member variables 

        public void ValidatingFunds(Player player, double amount)
        {
            if (player.amountOfMoney < amount)
            {
                string noMoney = "you don't have enough money to buy that.";
                UI.DisplayMessage(noMoney);
            }
            else
            {
                player.amountOfMoney -= amount;
                string yesMoney = "You have this much money now: ";
                UI.DisplayMessage(yesMoney + player.amountOfMoney);
            }
        }
    }
}
