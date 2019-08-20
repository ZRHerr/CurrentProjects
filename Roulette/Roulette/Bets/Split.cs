using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Split
    {
        public int SplitBet(int spin)
        {
            WheelSpin wheel = new WheelSpin();
            int splitNumber1;
            int splitNumber2 = 0;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            WriteText.WriteLine("Split Bet:", ConsoleColor.Yellow);
            WriteText.Write("You are making a split bet. Select your first number: ", ConsoleColor.Red);
            splitNumber1 = Int32.Parse(Console.ReadLine());
            if (column1.Contains(splitNumber1))
            {
                if (splitNumber1 == 1)
                {
                    WriteText.Write("Please enter the number you wish to split with (2, or 4): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 34)
                {
                    WriteText.Write("Please enter the number you wish to split with (31, or 35): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 1 && splitNumber1 != 34)
                {
                    WriteText.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 + 1}, or {splitNumber1 + 3}): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }
            if (column2.Contains(splitNumber1))
            {
                if (splitNumber1 == 2)
                {
                    WriteText.Write("Please enter the number you wish to split with (1, 3, or 5): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 35)
                {
                    WriteText.Write("Please enter the number you wish to split with (32, 34, 36): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 2 && splitNumber1 != 35)
                {
                    WriteText.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 - 1}, {splitNumber1 + 1}, or {splitNumber1 + 3}): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }
            if (column3.Contains(splitNumber1))
            {
                if (splitNumber1 == 3)
                {
                    WriteText.Write("Please enter the number you wish to split with (2, or 6): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 == 36)
                {
                    WriteText.Write("Please enter the number you wish to split with (33, or 35): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
                if (splitNumber1 != 3 && splitNumber1 != 36)
                {
                    WriteText.Write($"Please enter the number you wish to split with ({splitNumber1 - 3}, {splitNumber1 - 1}, or {splitNumber1 + 3}): ", ConsoleColor.Red);
                    splitNumber2 = Int32.Parse(Console.ReadLine());
                }
            }

            WriteText.Write($"You have ${Player.money}. Please enter how much you would like to bet: ", ConsoleColor.Red);
            bet = Int32.Parse(Console.ReadLine());
            if (bet > Player.money)
            {
                throw new System.IndexOutOfRangeException("You bet more than you have.");
            }
            if (bet <= Player.money)
            {
                wheel.displayWheel();
                Player.money = Player.money - bet;
                if (red.Contains(spin))
                {
                    if (spin == splitNumber1 || spin == splitNumber2)
                    {
                        winnings = 17 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin != splitNumber1 || spin != splitNumber2)
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (black.Contains(spin))
                {
                    if (spin == splitNumber1 || spin == splitNumber2)
                    {
                        winnings = 17 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (spin != splitNumber1 || spin != splitNumber2)
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
