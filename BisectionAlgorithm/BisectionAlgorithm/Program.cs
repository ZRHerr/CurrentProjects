using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BisectionAlgorithm;

namespace BisectionAlgorithm
{
    class Program
    {
        static Menu menu;
        
        static void Main(string[] args)
        {
            
            menu = new Menu()
            {
                new MenuItem("BisectionAlgorithm", RunBisect),
                new MenuItem("Guess the Computers Random Num:", RunHumanGuessing),
                new MenuItem("Try to stump the computer", RunComputerGuessing),
                new MenuItem("Exit", ()=> menu.Hide()),              
            };
            menu.ShowNavigationBar = true;
            menu.CyclicScrolling = true;
            menu.HorizontalAligment = MenuHorizontalAligment.Center;
            menu.Show();
            Console.ReadKey(true);
        }

        static void RunBisect()
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
            Console.ReadKey(true);
            menu.Show();
        }

        static void RunHumanGuessing()
        {
            HumanGuessing h = new HumanGuessing();
            h.Guess();
            Console.ReadKey(true);
            menu.Show();
        }

        static void RunComputerGuessing()
        {
            ComputerGuessing c = new ComputerGuessing();
            c.Guess();
            Console.ReadKey(true);
            menu.Show();
        }
    }
}
