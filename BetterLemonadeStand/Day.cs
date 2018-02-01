using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Day
    {
        //member variables 
        string day1;
        string day2;
        string day3;
        string day4;
        string day5;
        string day6;
        string day7;

        //constructor
        public Day()
        {
            day1 = "Monday";
            day2 = "Tueday";
            day3 = "Wednesday";
            day4 = "Thursday";
            day5 = "Friday";
            day6 = "Saturday";
            day7 = "Sunday";
        }

        //member methods
        public void DisplayDays(int number)
        {
            if (number == 1)
            {
                UI.DisplayMessage(day1);
            }
            else if (number == 2)
            {
                UI.DisplayMessage(day2);
            }
            else if (number == 3)
            {
                UI.DisplayMessage(day3);
            }
            else if (number == 4)
            {
                UI.DisplayMessage(day4);
            }
            else if (number == 5)
            {
                UI.DisplayMessage(day5);
            }
            else if (number == 6)
            {
                UI.DisplayMessage(day6);
            }
            else
            {
                UI.DisplayMessage(day7);
            }
        }
    }
}
