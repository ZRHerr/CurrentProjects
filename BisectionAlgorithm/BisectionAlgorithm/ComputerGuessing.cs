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
            Console.WriteLine("Lets see how many attempts it takes the computer\n" +
                "I'm rooting for you and that it took you less guesses!\n" +
                "Goodluck!\n");
            Console.Write("Pick your number beetween 1 and 1,000:");
            int userNum = 0;
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 1001)
                {
                    Console.WriteLine($"You chose {userNum}:");
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
                            Console.WriteLine($"The Computer guessed {MiddleNumber}: on its {ComputerAttempts} attempt:");
                            Console.WriteLine($"The computer now knows the number is somewhere between {LeftSide}-{RightSide}");
                            ComputerAttempts++;
                        }
                        else if (MiddleNumber < userNum)
                        {
                            LeftSide = MiddleNumber;
                            Console.WriteLine($"The Compute guessed {MiddleNumber}: You explained your number was lower than that\n" +
                                $"now the computer knows the number is somewhere between {LeftSide}-{RightSide}");
                            ComputerAttempts++;
                        }
                        else
                        {
                            Console.WriteLine($"Impressive; it only took the computer {ComputerAttempts} attempts to get it right\n" +
                                $"but, honestly {userNum}? you could have chosen a better number");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a valid number\n" +
                        "Come on you have options here 1-1000 is a big range try again:");
                    Console.ReadLine();
                    Guess();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Exception caught try again");
                Console.ReadLine();
                Guess();
            }
        }
    }
}
