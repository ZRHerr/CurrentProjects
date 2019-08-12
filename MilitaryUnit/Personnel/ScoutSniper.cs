using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class ScoutSniper : People, IWeaponAssignment
    {
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
