using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Number
    {
        public int NumbersBet(int spin)
        {
            int bet = 0;
            int number = 0;
            int winnings = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            WriteText.Write("Please enter the number you would like to bet on up to 36: ", ConsoleColor.Red);
            number = Int32.Parse(Console.ReadLine());
            WriteText.Write($"You have ${Player.money}. Please enter how much you would like to bet: ", ConsoleColor.Red);
            bet = Int32.Parse(Console.ReadLine());
            if (bet > Player.money)
            {
                throw new System.IndexOutOfRangeException("You bet more than you have.");
            }
            if (bet <= Player.money)
            {
                Player.money = Player.money - bet;

                if (red.Contains(spin))
                {
                    WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                }
                if (black.Contains(spin))
                {
                    WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                }
                if (green.Contains(spin))
                {
                    if (spin == 00)
                    {
                        WriteText.WriteLine($"The spin was {spin} green.", ConsoleColor.Red);
                    }
                    else
                    {
                        WriteText.WriteLine($"The spin was {spin} green.", ConsoleColor.Red);
                    }
                }
                if (spin == number)
                {
                    winnings = 35 * bet;
                    Player.money = winnings + Player.money;
                    WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                }
                if (spin != number)
                {
                    WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                }
            }
            return Player.money;
        }
    }
}
