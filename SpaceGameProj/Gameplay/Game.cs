using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Game
    {
        public void RunNewGame()
        {
            // Generates new planet list.
            List<SolarSystem> universe = PlanetGenerator.SomeGuysSky();

            // Creates the marketplace
            Items[] tradingGoods = Init.CreateTradingGoods();
            string[] TradeMenu = PlanetMenu.CreateTradeMenus(tradingGoods);

            //Creates Character
            Character myCharacter = new Character();
            Console.Clear();

            ShowActionMenu(myCharacter, universe, tradingGoods, TradeMenu);

        }
        private static void ShowActionMenu(Character myCharacter, List<SolarSystem> universe, Items[] tradingGoods, string[] TradeMenu)
        {
            bool keepLooping = true;
            do
            {
                bool commandNotExecuted = true;
                do
                {
                    Menus.WelcomeScreen();
                    try
                    {
                        Console.Write("\nSelect from the following options:\n\n1. Status\n2. Trade\n3. Travel to...\n4. Refuel\n5. Change ship\n6. Quit game\n\n>>> ");
                        MenuSelection selection = new MenuSelection(Console.ReadLine().Trim());
                        if (Enumerable.Range(1, 6).Contains(selection.GetSelection()))
                        {
                            switch (selection.GetSelection())
                            {
                                case 1:
                                    Console.Clear();
                                    Menus.WelcomeScreen();
                                    myCharacter.ShowStatus();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Menus.WelcomeScreen();
                                    Trade(tradingGoods, myCharacter, TradeMenu);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Menus.WelcomeScreen();
                                    myCharacter.Travel(universe);
                                    break;
                                case 4:
                                    Console.Clear();
                                    Menus.WelcomeScreen();
                                    myCharacter.Refuel(true);
                                    break;
                                case 5:
                                    Console.Clear();
                                    Menus.WelcomeScreen();
                                    myCharacter.newShip(true);
                                    break;
                                case 6:
                                    Console.Clear();
                                    Init i = new Init();
                                    i.Run();
                                    break;
                            }
                            commandNotExecuted = false;
                        }
                        else
                        {
                            Console.Clear();
                            throw new Exception("\nInvalid Entry");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (commandNotExecuted);
                Console.WriteLine("\nCommand successfully executed. Press Enter to Continue.");
                Console.ReadLine();
                Console.Clear();
            } while (keepLooping);
        }

        // Executes the trading decisions
        private static void Trade(Items[] tradingGoods, Character myCharacter, string[] TradeMenu)
        {
            string buyMenu = TradeMenu[0];
            string sellMenu = TradeMenu[1];
            bool keepLooping = true;
            do
            {
                Console.Write("\nSelect from the following options:\n\n1. Buy\n2. Sell\n\nC: Cancel\n\n>>> ");
                MenuSelection selection = new MenuSelection(Console.ReadLine().Trim());
                try
                {
                    if (selection.GetSelection() == 0)
                    {
                        break;
                    }
                    else if (selection.GetSelection() == 1)
                    {
                        myCharacter.BuyGoods(buyMenu, tradingGoods);
                    }
                    else if (selection.GetSelection() == 2)
                    {
                        myCharacter.SellGoods(sellMenu, tradingGoods);
                    }
                    else
                    {
                        throw new Exception("\nInvalid Entry");
                    }
                    keepLooping = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            } while (keepLooping);
        }
    }
}
