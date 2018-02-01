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


        public void ValidatingFunds(double amount)
        {
            if (player.money < amount)
            {
                string noMoney = "you don't have enough money to buy that.";
                UI.DisplayMessage(noMoney);
            }
            else
            {
                player.Money -= amount;
                string amountAfter = "You have this much money now: ";
                UI.DisplayMessage(amountAfter + player.Money);
            }
        }
    }
}
