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
            Console.WriteLine("Please enter a number ranging from 1-10");
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 11)
                {
                    // guarding against invalid input
                    Console.WriteLine($"You Selected {userNum}");
                    // returning the entered value
                    return userNum;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number ranging from 1-10");
                    Console.ReadLine();
                    UserInputNumber();
                }
            }
                catch (Exception)
                {
                Console.WriteLine("Caught Exception\nPlease try again");
                Console.ReadLine();
                UserInputNumber();
                }
            return userNum;
        }
    }
}
