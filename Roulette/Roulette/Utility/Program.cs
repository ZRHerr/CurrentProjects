using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Roulette
{
    class Program
    {
        Menus menu = new Menus();
        static void Main(string[] args)
        {
            Menus menu = new Menus();
            Weather weather;
            weather = new Weather();
            weather.SetRealWeatherAsync();
            menu.DisplayTitle();
            Console.ReadLine();
            Console.Clear();
            menu.Play();
        }
    }
}
