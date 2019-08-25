using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool tryagain = false;
            do
            {
                BisectInput input = new BisectInput();
                input.UserInputNumber();
                Bisection b = new Bisection();
                int[] myArray = b.Algorithm;
                int num = input.userNum;
                b.BisectionMethod(myArray, num);

                Console.WriteLine("Would you like to try another number? type \"yes\" or \"no\"");
                string YesOrNo = Convert.ToString(Console.ReadLine());
                if (YesOrNo.ToLower() == "yes")
                {
                    Console.Clear();
                    tryagain = true;
                }
                else if (YesOrNo.ToLower() == "no")
                {
                    tryagain = false;
                }
                else
                {
                    Console.WriteLine("Invalid Entry defaulting as yes, please next time enter yes or no");
                    Console.ReadLine();
                    Console.Clear();
                    tryagain = true;
                }
            } while (tryagain == true);


        }
    }
}
