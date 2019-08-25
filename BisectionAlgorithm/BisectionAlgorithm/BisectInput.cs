using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class BisectInput
    {
        public int userNum = 0;
        public int UserInputNumber()
        {
            WriteText.WriteLine("Please enter a number ranging from 1-10",ConsoleColor.DarkYellow);
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 11)
                {
                    // guarding against invalid input
                    WriteText.WriteLine($"You Selected {userNum}",ConsoleColor.DarkRed);
                    // returning the entered value
                    return userNum;
                }
                else
                {
                    WriteText.WriteLine("Please enter a valid number ranging from 1-10",ConsoleColor.Red);
                    Console.ReadLine();
                    UserInputNumber();
                }
            }
                catch (Exception)
                {
                WriteText.WriteLine("Caught Exception\nPlease try again",ConsoleColor.Red);
                Console.ReadLine();
                UserInputNumber();
                }
            return userNum;
        }
    }
}
