using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Corner
    {
        public int CornerBet(int spin)
        {
            int cornerNumber;
            int winnings = 0;
            int bet = 0;
            bool win = false;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] PlayerCorner = new int[4];

            WriteText.Write("You are making a corner bet. Select the number that will be located at the bottom left corner of your square: ", ConsoleColor.Red);
            cornerNumber = Int32.Parse(Console.ReadLine());
            if (column1.Contains(cornerNumber) || column2.Contains(cornerNumber))
            {
                PlayerCorner[0] = cornerNumber;
                PlayerCorner[1] = cornerNumber + 1;
                PlayerCorner[2] = cornerNumber + 3;
                PlayerCorner[3] = cornerNumber + 4;
            }

            if (column3.Contains(cornerNumber))
            {
                PlayerCorner[0] = cornerNumber;
                PlayerCorner[1] = cornerNumber - 1;
                PlayerCorner[2] = cornerNumber + 3;
                PlayerCorner[3] = cornerNumber + 2;
            }

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
                    foreach (int i in PlayerCorner)
                    {
                        if (spin == i)
                        {
                            win = true;
                            break;
                        }
                        if (spin != i)
                        {
                            win = false;
                        }
                    }
                    if (win == true)
                    {
                        winnings = 8 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (win == false)
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (black.Contains(spin))
                {
                    foreach (int i in PlayerCorner)
                    {
                        if (spin == i)
                        {
                            win = true;
                            break;
                        }
                        if (spin != i)
                        {
                            win = false;
                        }
                    }
                    if (win == true)
                    {
                        winnings = 8 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (win == false)
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
