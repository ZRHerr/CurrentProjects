using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Init
    {
        Menus m = new Menus();
        public static Items[] CreateTradingGoods()
        {
            Items[] arrayOfGoods = new Items[12];
            {
                arrayOfGoods[0] = new Items("Zen:", 30, 10);
                arrayOfGoods[1] = new Items("RotWood:", 150, 9);
                arrayOfGoods[2] = new Items("Iridium:", 400, 8);
                arrayOfGoods[3] = new Items("Adamantite:", 550, 7);
                arrayOfGoods[4] = new Items("VoidStone:", 950, 7);
                arrayOfGoods[5] = new Items("Meteorite:", 1000, 7);
                arrayOfGoods[6] = new Items("FireStone:", 1100, 8);
                arrayOfGoods[7] = new Items("Plutonium:", 1950, 4);
                arrayOfGoods[8] = new Items("Magic Dust:", 2000, 7);
                arrayOfGoods[9] = new Items("Nanite:", 2550, 5);
                arrayOfGoods[10] = new Items("Galaxy Stone:", 9500, 3);
                arrayOfGoods[11] = new Items("DarkMatter:", 20000, 1);

            };
            return arrayOfGoods;
        }
        public void Run()
        {
            //Intro.IntroCinematic();

            var exitGame = false;
            do
            {
                m.MainMenu();
                var result = Console.ReadLine();

                switch (result)
                {
                    case "1":
                        SelectedAction(1);
                        break;
                    case "2":
                        SelectedAction(2);
                        break;
                    case "3":
                        SelectedAction(3);
                        break;
                    default:
                        m.MainMenu();
                        break;
                }
                exitGame = SelectedAction(UserInput());
            } while (!exitGame);
            if (exitGame == true)
            {
                Environment.Exit(0);
            }
        }
        private int UserInput()
        {
            var input = false;
            int selection = 0;
            do
            {
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    input = true;
                }
                catch (FormatException)
                {
                    WriteText.WriteLine("Invalid Selection");
                    Console.ReadLine();
                    Run();
                }
            } while (!input);
            return selection;
        }
        public bool SelectedAction(int selection)
        {
            var exitGame = false;
            switch (selection)
            {
                case 1:
                    new Game().RunNewGame();
                    break;
                case 2:
                    new Menus().HighScores();
                    break;
                case 3:
                    exitGame = true;
                    Environment.Exit(0);
                    break;
            }
            return exitGame;
        }
    }
}
