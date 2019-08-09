using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpaceGameProj.Enums;

namespace SpaceGameProj
{
    public class Menus
    {
        internal static void WelcomeScreen()
        {
            WriteText.WriteLine("                       ╔═══════════════════════════════════════════════════════════════════════════╗", ConsoleColor.Yellow);
            WriteText.WriteLine("                       ║  ____                          ____             _       ____  _           ║", ConsoleColor.Yellow);
            WriteText.WriteLine("                       ║ / ___|  ___  _ __ ___   ___   / ___|_   _ _   _( )___  / ___|| | ___   _  ║", ConsoleColor.Yellow);
            WriteText.WriteLine(@"                       ║ \___ \ / _ \| '_ ` _ \ / _ \ | |  _| | | | | | |// __| \___ \| |/ / | | | ║", ConsoleColor.Yellow);
            WriteText.WriteLine(@"                       ║  ___) | (_) | | | | | |  __/ | |_| | |_| | |_| | \__ \  ___) |   <| |_| | ║", ConsoleColor.Yellow);
            WriteText.WriteLine(@"                       ║ |____/ \___/|_| |_| |_|\___|  \____|\__,_|\__, | |___/ |____/|_|\_\\__, | ║", ConsoleColor.Yellow);
            WriteText.WriteLine("                       ║                                           |___/                    |___/  ║", ConsoleColor.Yellow);
            WriteText.WriteLine("                       ║                                                                           ║", ConsoleColor.Yellow);
            WriteText.WriteLine("                       ╚═══════════════════════════════════════════════════════════════════════════╝", ConsoleColor.Yellow);
            WriteText.WriteLine("------------------------------------------------------------------------------------------------------------------------", ConsoleColor.Yellow);
        }
        internal static MenuChoice DisplayMenu()
        {
            Console.Clear();
            WriteText.WriteLine("                       ╔═══════════════════════════════════════════════════════════════════════════╗", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║  ____                          ____             _       ____  _           ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║ / ___|  ___  _ __ ___   ___   / ___|_   _ _   _( )___  / ___|| | ___   _  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ \___ \ / _ \| '_ ` _ \ / _ \ | |  _| | | | | | |// __| \___ \| |/ / | | | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║  ___) | (_) | | | | | |  __/ | |_| | |_| | |_| | \__ \  ___) |   <| |_| | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ |____/ \___/|_| |_| |_|\___|  \____|\__,_|\__, | |___/ |____/|_|\_\\__, | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                                           |___/                    |___/  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                              START/LOAD GAME                              ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ╚═══════════════════════════════════════════════════════════════════════════╝", ConsoleColor.DarkGreen);
            WriteText.WriteLine("------------------------------------------------------------------------------------------------------------------------", ConsoleColor.DarkRed);
            WriteText.WriteLine("Please choose a number from the menu", ConsoleColor.Green);
            WriteText.WriteLine("");
            WriteText.WriteLine("1. Start a new game", ConsoleColor.DarkGreen);
            WriteText.WriteLine("2. Load a previus game", ConsoleColor.DarkGreen);
            WriteText.WriteLine("3. HighScores", ConsoleColor.DarkGreen);
            WriteText.WriteLine("4. Exit the game", ConsoleColor.DarkGreen);

            var result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    return MenuChoice.NewGame;
                case "2":
                    return MenuChoice.LoadGame;
                case "3":
                    return MenuChoice.HighScores;
                case "4":
                    return MenuChoice.Exit;
                default:
                    return MenuChoice.Invalid;
            }
        }
        public void MainMenu()
        {
            Console.Clear();
            WriteText.WriteLine("                       ╔═══════════════════════════════════════════════════════════════════════════╗", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║  ____                          ____             _       ____  _           ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║ / ___|  ___  _ __ ___   ___   / ___|_   _ _   _( )___  / ___|| | ___   _  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ \___ \ / _ \| '_ ` _ \ / _ \ | |  _| | | | | | |// __| \___ \| |/ / | | | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║  ___) | (_) | | | | | |  __/ | |_| | |_| | |_| | \__ \  ___) |   <| |_| | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ |____/ \___/|_| |_| |_|\___|  \____|\__,_|\__, | |___/ |____/|_|\_\\__, | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                                           |___/                    |___/  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                                *Main Menu*                                ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ╚═══════════════════════════════════════════════════════════════════════════╝", ConsoleColor.DarkGreen);
            WriteText.WriteLine("------------------------------------------------------------------------------------------------------------------------", ConsoleColor.DarkRed);
            WriteText.WriteLine("Please choose a number from the menu", ConsoleColor.Green);
            WriteText.WriteLine("");
            WriteText.WriteLine("1. Start a new game", ConsoleColor.DarkGreen);
            WriteText.WriteLine("2. HighScores", ConsoleColor.DarkGreen);
            WriteText.WriteLine("3. Exit the game", ConsoleColor.DarkGreen);
        }

        public void HighScores()
        {
            Console.Clear();
            WriteText.WriteLine("                       ╔═══════════════════════════════════════════════════════════════════════════╗", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║  ____                          ____             _       ____  _           ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║ / ___|  ___  _ __ ___   ___   / ___|_   _ _   _( )___  / ___|| | ___   _  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ \___ \ / _ \| '_ ` _ \ / _ \ | |  _| | | | | | |// __| \___ \| |/ / | | | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║  ___) | (_) | | | | | |  __/ | |_| | |_| | |_| | \__ \  ___) |   <| |_| | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine(@"                       ║ |____/ \___/|_| |_| |_|\___|  \____|\__,_|\__, | |___/ |____/|_|\_\\__, | ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                                           |___/                    |___/  ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ║                               *High Scores*                               ║", ConsoleColor.DarkGreen);
            WriteText.WriteLine("                       ╚═══════════════════════════════════════════════════════════════════════════╝", ConsoleColor.DarkGreen);
            WriteText.WriteLine("------------------------------------------------------------------------------------------------------------------------", ConsoleColor.DarkRed);
            WriteText.WriteLine("1. 10,000 Points - Bill Jeffreys\n2. 8,000 Points - Jeff Billfreys\n3. 6,000 Points - Will Williamson\n 4. 4,000 Points - Bill Billiamson", ConsoleColor.Green);
            WriteText.WriteLine("");
            WriteText.WriteLine("PRESS ENTER TO GO BACK", ConsoleColor.DarkGreen);
            Console.ReadLine();
            new Init().Run();
        }
    }
}
