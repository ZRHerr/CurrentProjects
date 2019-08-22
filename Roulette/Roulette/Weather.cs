using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Weather
    {
        public int Temperature
        {
            get;set; 
        }
        public string WeatherEffect
        {
            get; set;
        }
        public Weather()
        {
            //    SetRealWeatherAsync();
            //this.Temperature = this.Temperature;
            //this.WeatherEffect = this.WeatherEffect;
        }
        public async void SetRealWeatherAsync()
        {
            int[] results = await WeatherAPI.GetRealWeather();

            int cloudPercentage = results[0];
            this.Temperature = ConvertKelvinToFahrenheit(results[1]);
            int humidity = results[2];
            this.WeatherEffect = SetRealWeatherEffect(cloudPercentage, humidity);
            DisplayWeather();
            //return true;
        }
        private int ConvertKelvinToFahrenheit(int kelvin)
        {
            return Convert.ToInt32((9.0 / 5.0) * (kelvin - 273) + 32);
        }
        private void DisplayWeather()
        {
            Console.WriteLine("\n\nThe weather ended up being {0} degrees and {1} today.", this.Temperature, this.WeatherEffect);
        }
        private string SetRealWeatherEffect(int cloudPercentage, int humidity)
        {

            if (humidity >= 95)
            {
                return "Rainy now that your soaked lets try not to lose fast";
            }
            else if (cloudPercentage >= 90)
            {
                return "Overcast looks like you will be here a while";
            }
            else if (humidity >= 80)
            {
                return "Foggy you probably shouldn't have driven here";
            }
            else if (cloudPercentage >= 30)
            {
                return "Cloudy lets hope your brain isn't";
            }
            else if (humidity >= 40)
            {
                return "Humid what a great day to be indoors";
            }
            else
            {
                return "Sunny wouldnt you rather go to the beach";
            }
        }
    }
}
