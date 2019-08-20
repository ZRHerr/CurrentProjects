using Roulette.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RedOrBlack
    {
        public int RedOrBlackBet(int spin)
        {
            WheelSpin wheel = new WheelSpin();
            string redOrBlack;
            int winnings = 0;
            int bet = 0;
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] green = { 0, 37 };
            WriteText.WriteLine("Red/Black Bet:", ConsoleColor.Yellow);
            WriteText.Write("Please Enter red or black: ", ConsoleColor.Red);
            redOrBlack = Console.ReadLine();
            redOrBlack.ToLower();

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

                if (red.Contains(spin) && redOrBlack == "red")
                {
                    winnings = 2 * bet;
                    Player.money = winnings + Player.money;
                    WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Green);
                    WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                }
                if (red.Contains(spin) && redOrBlack != "red")
                {
                    WriteText.WriteLine($"The spin was {spin} red.", ConsoleColor.Red);
                    WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
                }
                if (black.Contains(spin) && redOrBlack == "black")
                {
                    winnings = 2 * bet;
                    Player.money = winnings + Player.money;
                    WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Green);
                    WriteText.WriteLine($"You won ${winnings}. You now have ${Player.money}.", ConsoleColor.Green);
                }
                if (black.Contains(spin) && redOrBlack != "black")
                {
                    WriteText.WriteLine($"The spin was {spin} black.", ConsoleColor.Red);
                    WriteText.WriteLine($"You lost ${bet}. You now have ${Player.money}.", ConsoleColor.Red);
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

