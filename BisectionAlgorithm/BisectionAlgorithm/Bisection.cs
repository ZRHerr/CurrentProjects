using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Bisection
    {
        public int[] Algorithm = {1,2,3,4,5,6,7,8,9,10};
        string tryagain = Convert.ToString(Console.ReadLine());
        public int BisectionMethod(int[] Algorithm, int userNum)
        {
            int LeftSide = 0;
            int RightSide = Algorithm.Length - 1;

            //Cuts array in half based on the User Input
            while(LeftSide <= RightSide)
            {
                //Finds the middle number in the current array
                int MiddleNumber = LeftSide + (RightSide - LeftSide) / 2;

                //Checks to see if the input falls within the small end of the array
                if(Algorithm[MiddleNumber] > userNum)
                {
                    WriteText.WriteLine($"The current number range is {LeftSide+1}-{RightSide+1}",ConsoleColor.DarkYellow);
                    RightSide = MiddleNumber - 1;                    
                    WriteText.WriteLine($"your number is less than the middle number: {MiddleNumber+1}\tThe next Numbers to check is: {LeftSide+1}-{RightSide+1}\n",ConsoleColor.Yellow);
                }
                // Checks the input falling within the big end of the array
                else if (Algorithm[MiddleNumber] < userNum)
                {
                    WriteText.WriteLine($"The current number range is {LeftSide+1}-{RightSide+1}",ConsoleColor.DarkYellow);
                    LeftSide = MiddleNumber + 1;
                    WriteText.WriteLine($"your number is more than the middle number: {MiddleNumber+1}\tThe next Numbers to check is: {LeftSide + 1}-{RightSide + 1}\n",ConsoleColor.Yellow);

                }
                // Last else returns the middle number to narrow down the search
                else
                {
                    WriteText.WriteLine($"The Number fell in the middle of the above checked range your number was: {userNum}",ConsoleColor.DarkGreen);
                    Console.ReadLine();
                    return MiddleNumber;
                }
            }return 0;

        }
        

    }
}
