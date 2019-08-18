using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class LowsHighs
    {
        public int LowOrHighBet(int spin)
        {
            string lowOrHigh;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            WriteText.Write("Would you like to bet on lows (1-18) or highs (19-36)? Please enter low/high: ", ConsoleColor.Red);
            lowOrHigh = Console.ReadLine();
            lowOrHigh.ToLower();

            WriteText.Write($"You have ${Player.money}. Please enter how much you would like to bet: ", ConsoleColor.Red);
            bet = Int32.Parse(Console.ReadLine());
            if (bet > Player.money)
            {
                throw new System.IndexOutOfRangeException("You bet more than you have.");
            }
            if (bet <= Player.money)
            {
                if (red.Contains(spin))
                {
                    Player.money = Player.money - bet;
                    if (spin <= 18 && spin >= 1 && lowOrHigh == "low")
                    {
                        winnings = 2 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin <= 18 && spin >= 1 && lowOrHigh != "low")
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (spin >= 19 && lowOrHigh == "high")
                    {
                        winnings = 2 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin >= 19 && lowOrHigh != "high")
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (spin == 0 || spin == 00)
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (black.Contains(spin))
                {
                    Player.money = Player.money - bet;
                    if (spin <= 18 && spin >= 1 && lowOrHigh == "low")
                    {
                        winnings = 2 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin <= 18 && spin >= 1 && lowOrHigh != "low")
                    {
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (spin >= 19 && lowOrHigh == "high")
                    {
                        winnings = 2 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin >= 19 && lowOrHigh != "high")
                    {
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (green.Contains(spin))
                {
                    if (spin == 0 || spin == 00)
                    {
                        WriteText.WriteLine($"The spin was {spin} green.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
            }
            return Player.money;
        }
    }
}

