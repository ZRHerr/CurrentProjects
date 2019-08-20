using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Columns
    {
        public int ColumnBet(int spin)
        {
            WheelSpin wheel = new WheelSpin();
            string column;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            WriteText.WriteLine("Column Bet:", ConsoleColor.Yellow);
            WriteText.WriteLine("Please Enter number (1) (2) or (3) See board above (1:Bottom, 2:Middle, 3:Top)", ConsoleColor.Red);
            column = Console.ReadLine();
            column.ToLower();

            WriteText.WriteLine($"You have ${Player.money}. Please enter how much you would like to bet: ", ConsoleColor.Red);
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
                    if (column1.Contains(spin) && column == "first")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column1.Contains(spin) && column != "first")
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (column2.Contains(spin) && column == "second")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column2.Contains(spin) && column != "second")
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (column3.Contains(spin) && column == "third")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column3.Contains(spin) && column != "third")
                    {
                        WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                }
                if (black.Contains(spin))
                {
                    if (column1.Contains(spin) && column == "first")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column1.Contains(spin) && column != "first")
                    {
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (column2.Contains(spin) && column == "second")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column2.Contains(spin) && column != "second")
                    {
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                        WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                    }
                    if (column3.Contains(spin) && column == "third")
                    {
                        winnings = 3 * bet;
                        Player.money = winnings + Player.money;
                        WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                        WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                    }
                    if (column3.Contains(spin) && column != "third")
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

