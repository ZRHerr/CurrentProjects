using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class HumanGuessing
    {
        public void Guess()
        {
            Console.Clear();
            int userGuess = -1;
            int attempts = 1;
            Random rnd = new Random();
            int ComputerPick = rnd.Next(0, 1000);
            WriteText.WriteLine("Try to guess the number the computer has selected between 1-1000",ConsoleColor.Blue);
            WriteText.WriteLine("After each guess a hint will be displayed to help you place your next guess\n" +
                "How many attempts will it take?");
            WriteText.WriteLine("Press enter to start",ConsoleColor.DarkGreen);
            Console.ReadLine();
            while(userGuess != ComputerPick)
            {
                try
                {
                    Console.Clear();
                    WriteText.WriteLine($"This is your {attempts} attemp:\t Input your guess:",ConsoleColor.DarkYellow);
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess > 0 && userGuess < 1001)
                    {
                        WriteText.WriteLine($"You chose {userGuess} on your {attempts} attempt",ConsoleColor.DarkYellow);
                        //checking to see if the number is correct
                        if (userGuess == ComputerPick)
                        {
                            WriteText.WriteLine($"You got it!\n" +
                                $"it only took you {attempts} attempts",ConsoleColor.DarkGreen);
                            WriteText.WriteLine("Press Enter to return to the Main Menu");
                            Console.ReadKey();
                        }
                        //Checking to see if the number is higher than the computers random num
                        else if (userGuess > ComputerPick)
                        {
                            WriteText.WriteLine("Your number is higher than the computers pick, try a little lower\n",ConsoleColor.DarkRed);
                            attempts++;
                            WriteText.WriteLine("Press Enter to guess again:");
                            Console.ReadKey();
                        }
                        //Checking to see if its lower
                        else if (userGuess < ComputerPick)
                        {
                            WriteText.WriteLine("Your number is lower than the computers pick, try a little higher\n",ConsoleColor.DarkRed);
                            attempts++;
                            WriteText.WriteLine("Press Enter to guess again:");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        WriteText.WriteLine("Come on now your getting off track\n" +
                            "Please input a valid number(that is gonna cost you an attempt)",ConsoleColor.Yellow);
                        attempts++;
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    WriteText.WriteLine("Exception Caught\n" +
                        "Invalid input",ConsoleColor.Red);
                }
                
            }
        }
    }
}
