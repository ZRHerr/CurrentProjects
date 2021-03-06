﻿using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Roulette
{
    public class Menus : WheelSpin
    {

        public void DisplayTitle()
        { 
            WriteText.WriteLine($"*******                     **           **     **            ", ConsoleColor.Red);
            WriteText.WriteLine($"/**////**                   /**          /**    /**           ", ConsoleColor.Red);
            WriteText.WriteLine($"/**   /**   ******  **   ** /**  *****  ****** ******  *****", ConsoleColor.Red); 
            WriteText.WriteLine($"/*******   **////**/**  /** /** **///**///**/ ///**/  **///**", ConsoleColor.Red);
            WriteText.WriteLine($"/**///**  /**   /**/**  /** /**/*******  /**    /**  /*******", ConsoleColor.Red);
            WriteText.WriteLine($"/**  //** /**   /**/**  /** /**/**////   /**    /**  /**//// ", ConsoleColor.Red); 
            WriteText.WriteLine($"/**   //**//****** //****** ***//******  //**   //** //******", ConsoleColor.Red);
            WriteText.WriteLine($"//     //  //////   ////// ///  //////    //     //   //////", ConsoleColor.Red);
            WriteText.WriteLine("");
            WriteText.WriteLine("");
            WriteText.WriteLine("");
            WriteText.WriteLine("Press any key to continue: Goodluck!", ConsoleColor.Red);
        }
        public void DisplayTable()
        {
            WriteText.WriteLine("    +--------------------------------------------------------+       C", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 | 33 | 36 | 3 --> O", ConsoleColor.DarkYellow);
            WriteText.WriteLine("+---+ -------------------------------------------------------|       L", ConsoleColor.DarkYellow);
            WriteText.WriteLine("| 0 | 2 | 5 | 8 | 11 | 14 | 17 | 20 | 23 | 26 | 29 | 32 | 35 | 2 --> U", ConsoleColor.DarkYellow);
            WriteText.WriteLine("+ --+--------------------------------------------------------|       M", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    | 1 | 4 | 7 | 10 | 13 | 16 | 19 | 22 | 25 | 28 | 31 | 34 | 1 --> N", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    + -------------------------------------------------------+       S", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    |                |                   |                   |", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    |     1st 12     |       2nd 12      |       3rd 12      |", ConsoleColor.DarkYellow);
            WriteText.WriteLine("    +----------------+-------------------+-------------------+", ConsoleColor.DarkYellow);

        }
        //Weather weather;
        public void Play()
        {
            bool play;
            string playAgain;
            //Moved this to the opening screen in program.
            //weather = new Weather();
            //weather.SetRealWeatherAsync();
            
                while (play = true && Player.money > 0)
                {
                    Console.Clear();
                DisplayTable();
                WriteText.WriteLine("");
                WriteText.WriteLine("");
                WriteText.WriteLine("");

                //Console.WriteLine("The Temperture today is {0} degrees and {1} today.", weather.Temperature, weather.WeatherEffect);
                WriteText.WriteLine($"Choose a number cooresponding to the bet you'd like to make\n" +
                        $"1: bet on a number(1/36 odds)\t 2: Even or Odds(1/2 odds)\t 3: Red or Black(1/2 odds)\n" +
                        $"4: Lows or Highs(1/2 odds)\t 5: Dozens(1/3 odds)\t 6: Column bet(1/3 odds)\n" +
                        $"7: Street(1/12 odds)\t 8: six-line(1/6 odds)\t 9: Split(1/18 odds)\n" +
                        $"10: Corner bet(1/9 odds)", ConsoleColor.Green);
                    int chosenBet = Int32.Parse(Console.ReadLine());
                    if (chosenBet > 10)
                    {
                        throw new IndexOutOfRangeException("You chose a number that does not correspond with any of the bets.");
                    }
                    if (chosenBet == 1)
                    {
                        Number number = new Number();
                        number.NumbersBet(Spin());
                    }
                    if (chosenBet == 2)
                    {
                        EvenOrOdd evenorodd = new EvenOrOdd();
                        evenorodd.EvenOrOddBet(Spin());
                    }
                    if (chosenBet == 3)
                    {
                        RedOrBlack redorblack = new RedOrBlack();
                        redorblack.RedOrBlackBet(Spin());
                    }
                    if (chosenBet == 4)
                    {
                        LowsHighs loworhigh = new LowsHighs();
                        loworhigh.LowOrHighBet(Spin());
                    }
                    if (chosenBet == 5)
                    {
                        Dozens dozens = new Dozens();
                        dozens.DozensBet(Spin());
                    }
                    if (chosenBet == 6)
                    {
                        Columns columns = new Columns();
                        columns.ColumnBet(Spin());
                    }
                    if (chosenBet == 7)
                    {
                        Street street = new Street();
                        street.StreetBet(Spin());
                    }
                    if (chosenBet == 8)
                    {
                        SixLine sixLine = new SixLine();
                        sixLine.SixLineBet(Spin());
                    }
                    if (chosenBet == 9)
                    {
                        Split split = new Split();
                        split.SplitBet(Spin());
                    }
                    if (chosenBet == 10)
                    {
                        Corner corner = new Corner();
                        corner.CornerBet(Spin());
                    }
                    if (Player.money == 0)
                    {
                        play = false;
                        WriteText.WriteLine("Thank you for playing. Good bye.", ConsoleColor.Red);
                        Console.ReadKey();
                    }
                    if (Player.money > 0)
                    {
                        WriteText.WriteLine("Would you like to play again (yes/no): ", ConsoleColor.Red);
                        playAgain = Console.ReadLine();
                        playAgain.ToLower();
                        if (playAgain == "yes")
                        {
                            play = true;
                            Random random = new Random();
                            int phrase = random.Next(1, 3);
                            if (phrase == 1)
                            {
                                WriteText.WriteLine("You'll certainly win more this time!", ConsoleColor.Red);
                            }
                            if (phrase == 2)
                            {
                                WriteText.WriteLine("Ah you like to live life on the edge. Fantastic lets play again!", ConsoleColor.Red);
                            }
                            if (phrase == 3)
                            {
                                WriteText.WriteLine("Luck is for the unskilled. You must be a very lucky person.", ConsoleColor.Red);
                            }
                        }
                        else if (playAgain == "no")
                        {
                            play = false;
                            WriteText.WriteLine("Thank you for playing. Good bye.", ConsoleColor.Red);
                            Console.ReadKey();
                        }
                    }
                }
           
        }
        private async Task TestWeatherAPI()
        {
            int[] results = await WeatherAPI.GetRealWeather();
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
