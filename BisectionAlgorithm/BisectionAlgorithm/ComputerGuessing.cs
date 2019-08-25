using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class ComputerGuessing
    {
        public void Guess()
        {
            Console.Clear();
            WriteText.WriteLine("Lets see how many attempts it takes the computer\n" +
                "I'm rooting for you and that it took you less guesses!\n" +
                "Goodluck!\n",ConsoleColor.DarkYellow);
            Console.Write("Pick your number beetween 1 and 1,000:",ConsoleColor.DarkGreen);
            int userNum = 0;
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 1001)
                {
                    WriteText.WriteLine($"You chose {userNum}:");
                    int LeftSide = 0;
                    int RightSide = 1000;
                    int MiddleNumber = -1;
                    int ComputerAttempts = 1;
                    while (userNum != MiddleNumber)
                    {
                        MiddleNumber = LeftSide + (RightSide - LeftSide) / 2;
                        if (MiddleNumber > userNum)
                        {
                            RightSide = MiddleNumber;
                            WriteText.WriteLine($"The Computer guessed {MiddleNumber}: on its {ComputerAttempts} attempt:",ConsoleColor.DarkRed);
                            WriteText.WriteLine($"The computer now knows the number is somewhere between {LeftSide}-{RightSide}",ConsoleColor.DarkYellow);
                            ComputerAttempts++;
                        }
                        else if (MiddleNumber < userNum)
                        {
                            LeftSide = MiddleNumber;
                            WriteText.WriteLine($"The Compute guessed {MiddleNumber}: You explained your number was higher than that\n" +
                                $"now the computer knows the number is somewhere between {LeftSide}-{RightSide}",ConsoleColor.DarkYellow);
                            ComputerAttempts++;
                        }
                        else
                        {
                            WriteText.WriteLine($"Impressive; it only took the computer {ComputerAttempts} attempts to get it right\n" +
                                $"but, honestly {userNum}? you could have chosen a better number",ConsoleColor.DarkGreen);
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    WriteText.WriteLine("Please Enter a valid number\n" +
                        "Come on you have options here 1-1000 is a big range try again:",ConsoleColor.Red);
                    Console.ReadLine();
                    Guess();
                }
            }
            catch(Exception)
            {
                WriteText.WriteLine("Exception caught try again",ConsoleColor.Red);
                Console.ReadLine();
                Guess();
            }
        }
    }
}
