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
            Console.WriteLine("Try to guess the number the computer has selected between 1-1000");
            Console.WriteLine("After each guess a hint will be displayed to help you place your next guess\n" +
                "How many attempts will it take?");
            Console.ReadLine();
            while(userGuess != ComputerPick)
            {
                try
                {
                    Console.Clear();
                    Console.Write($"This is your {attempts} attemp:\t Input your guess:");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess > 0 && userGuess < 1001)
                    {
                        Console.WriteLine($"You chose {userGuess} on your {attempts} attempt");
                        //checking to see if the number is correct
                        if (userGuess == ComputerPick)
                        {
                            Console.WriteLine($"You got it!\n" +
                                $"it only took you {attempts} attempts");
                        }
                        //Checking to see if the number is higher than the computers random num
                        else if (userGuess > ComputerPick)
                        {
                            Console.WriteLine("Your number is higher than the computers pick, try a little lower\n");
                            attempts++;
                        }
                        //Checking to see if its lower
                        else if (userGuess < ComputerPick)
                        {
                            Console.WriteLine("Your number is lower than the computers pick, try a little higher\n");
                            attempts++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Come on now your getting off track\n" +
                            "Please input a valid number(that is gonna cost you an attempt)");
                        attempts++;
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception Caught\n" +
                        "Invalid input");
                }
                
            }
        }
    }
}
