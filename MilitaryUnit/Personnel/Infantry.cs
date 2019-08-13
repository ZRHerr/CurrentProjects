using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Infantry : People, IWeaponAssignment
    {
        Random rnd = new Random();
        public Infantry()
        {
            int rndName = rnd.Next(0, personFirstName.Length - 1);
            int rndRank = rnd.Next(0, rank.Length - 1);
            string infantryrank = rank.ElementAt(rndRank);
            string infantryfirst =personFirstName.ElementAt(rndName);
            string infantrylast = personLastName.ElementAt(rndName);
            Console.WriteLine($"Welome {infantryrank},{infantryfirst},{infantrylast} from Alpha to the team");
            WeaponAssignment();
        }
        public override void Train(string a)
        {
            Console.WriteLine($"Goes to the field and runs out of cigarrettes", ConsoleColor.Red);
        }
        public void WeaponAssignment()
        {
            M16A4 m16 = new M16A4();
            Console.WriteLine($"The Weapon you will have is a {m16.weaponName}", ConsoleColor.Red);
            Console.WriteLine($"Your weapon is a {m16.weaponType}", ConsoleColor.Red);
            Console.WriteLine($"The weapon uses{m16.weaponAmmo}", ConsoleColor.Red);
            Console.WriteLine($"It fires {m16.weaponFireRate}", ConsoleColor.Red);
            Console.WriteLine($"Its Damage Level is {m16.weaponDamage}", ConsoleColor.Red);
        }
    }
}