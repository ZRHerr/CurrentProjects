using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class ScoutSniper : People, IWeaponAssignment
    {
        Random rnd = new Random();
        public ScoutSniper()
        {
            int rndName = rnd.Next(0, personFirstName.Length - 1);
            int rndRank = rnd.Next(0, rank.Length - 1);
            string sniperrank = rank.ElementAt(rndRank);
            string sniperfirst = personFirstName.ElementAt(rndName);
            string sniperlast = personLastName.ElementAt(rndName);
            Console.WriteLine($"Welome{sniperrank},{sniperfirst},{sniperlast} from scout snipers to the team");
            WeaponAssignment();
        }
        public override void Train(string a)
        {
            Console.WriteLine($"Hides and ends up doing nothing", ConsoleColor.Yellow);
        }
        public void WeaponAssignment()
        {
           BarrettM82 m82 = new BarrettM82();
            Console.WriteLine($"The Weapon you will have is a {m82.weaponName}", ConsoleColor.Yellow);
            Console.WriteLine($"Your weapon is a {m82.weaponType}", ConsoleColor.Yellow);
            Console.WriteLine($"The weapon uses{m82.weaponAmmo}", ConsoleColor.Yellow);
            Console.WriteLine($"It fires {m82.weaponFireRate}", ConsoleColor.Yellow);
            Console.WriteLine($"Its Damage Level is {m82.weaponDamage}", ConsoleColor.Yellow);
        }
    }
}
