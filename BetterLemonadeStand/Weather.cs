using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLemonadeStand
{
    class Weather
    {
            //member variables
            public int temperature;
            public int forecast;
            Random randTemp;
            Random randForecast;

            //member methods
            public int gettingTemp()
            {
                randTemp = new Random();
                temperature = randTemp.Next(50, 105);
                Console.WriteLine("temperature: " + temperature);
                return temperature;
            }

            public void gettingForecast()
            {
                randForecast = new Random();
                forecast = randForecast.Next(0, 3);
                if (forecast == 0)
                {
                    string clearSky = "Clear sky";
                    UI.DisplayMessage(clearSky);
                }
                else if (forecast == 1)
                {
                    string partlyCloudy = "Partly Cloudy";
                    UI.DisplayMessage(partlyCloudy);
                }
                else if (forecast == 2)
                {
                    string overcast = "Overcast";
                    UI.DisplayMessage(overcast);
                }
                else
                {
                string rain = "Rain";
                UI.DisplayMessage(rain);
                }

            }
        }
}
