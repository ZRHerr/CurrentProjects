using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    class PlanetMenu
    {
        public bool ExitingMenu { get; set; }

        public Items ChosenItem { get; set; }

        public static string[] CreateTradeMenus(Items[] tradingGoods)
        {
            // Building the output strings for buy and sell menus
            Console.Clear();
            Menus.WelcomeScreen();
            string itemList = "";
            int count = 1;
            foreach (Items items in tradingGoods)
            {

                itemList += count++ + ". " + items.GetName() + " " + items.GetPrice() + "\n";
                if (count > 12)
                {
                    itemList += "\n>>> ";
                }
            }
            string[] tradeMenu = { "\nWhat would you like to buy?\n\n" + itemList, "\nWhat would you like to sell?\n\n" + itemList };
            return tradeMenu;
        }

    }
}
