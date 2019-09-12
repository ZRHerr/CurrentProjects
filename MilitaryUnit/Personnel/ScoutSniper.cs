using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class ScoutSniper : People, IWeaponAssignment
    {
        public ScoutSniper()
        {
            Console.WriteLine($"Welome");
            SelectPeople();
            WeaponAssignment();
        }
        public override void Train(string a)
        {
            Console.WriteLine($"Hides and ends up doing nothing", ConsoleColor.Yellow);
        }
        public void WeaponAssignment()
        {
           BarrettM82 m82 = new BarrettM82();
            Console.WriteLine($"The Weapon you will have is a {m82.WeaponName}", ConsoleColor.Yellow);
            Console.WriteLine($"Your Weapon is a {m82.WeaponType}", ConsoleColor.Yellow);
            Console.WriteLine($"The Weapon uses{m82.WeaponAmmo}", ConsoleColor.Yellow);
            Console.WriteLine($"It fires {m82.WeaponFireRate}", ConsoleColor.Yellow);
            Console.WriteLine($"Its Damage Level is {m82.WeaponDamage}", ConsoleColor.Yellow);
        }
    }
}
