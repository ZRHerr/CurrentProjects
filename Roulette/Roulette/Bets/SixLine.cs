using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class SixLine
    {
        public int SixLineBet(int spin)
        {
            int street;
            int rangeOfStreet;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };

            WriteText.Write("To select a specific two rows of numbers please enter the lowest number in the street you wish to choose: ");
            street = Int32.Parse(Console.ReadLine());
            rangeOfStreet = street + 5;

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
                    if (spin <= rangeOfStreet && spin >= 1)
                    {
                        winnings = 6 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin > rangeOfStreet)
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (black.Contains(spin))
                {
                    if (spin <= rangeOfStreet && spin >= 1)
                    {
                        winnings = 6 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin > rangeOfStreet)
                    {
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (spin == 0 || spin == 00)
                {
                    WriteText.WriteLine($"The spin was {spin} green.", ConsoleColor.Red);
                    WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                }
            }
            return Player.money;
        }
    }
}
