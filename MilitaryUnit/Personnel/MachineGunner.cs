using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MachineGunner : People, IWeaponAssignment
    {
        Random rnd = new Random();
        public MachineGunner()
            {
                int rndName = rnd.Next(0, personFirstName.Length - 1);
                int rndRank = rnd.Next(0, rank.Length - 1);
                string gunnerrank = rank.ElementAt(rndRank);
                string gunnerfirst = personFirstName.ElementAt(rndName);
                string gunnerlast = personLastName.ElementAt(rndName);
                Console.WriteLine($"Welome{gunnerrank},{gunnerfirst},{gunnerlast} from Bravo Company to the team");
            WeaponAssignment();
            }
        
        public override void Train(string a)
        {
            Console.WriteLine($"Fires Blindly due to lack of sleep", ConsoleColor.Green);
        }
        public void WeaponAssignment()
        {
            M240L m240 = new M240L();
            Console.WriteLine($"The Weapon you will have is a {m240.weaponName}", ConsoleColor.Green);
            Console.WriteLine($"Your weapon is a {m240.weaponType}", ConsoleColor.Green);
            Console.WriteLine($"The weapon uses{m240.weaponAmmo}", ConsoleColor.Green);
            Console.WriteLine($"It fires {m240.weaponFireRate}", ConsoleColor.Green);
            Console.WriteLine($"Its Damage Level is {m240.weaponDamage}", ConsoleColor.Green);
        }
    }
}
