using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class GoodStudent : People, IWeaponAssignment
    {
        public override void Study(string a)
        {
            Console.WriteLine($"The Student Finishes SpaceGame", ConsoleColor.Green);
        }
        public override void Test(string a)
        {
            Console.WriteLine($"The Student is well above their peers", ConsoleColor.Green);
        }
        public void WeaponAssignment()
        {
            BarrettM82 m82 = new BarrettM82();
            Console.WriteLine($"The Weapon you will have is a {m82.weaponName}", ConsoleColor.Green);
            Console.WriteLine($"Your weapon is a {m82.weaponType}", ConsoleColor.Green);
            Console.WriteLine($"The weapon uses{m82.weaponAmmo}", ConsoleColor.Green);
            Console.WriteLine($"It fires {m82.weaponFireRate}", ConsoleColor.Green);
            Console.WriteLine($"Its Damage Level is {m82.weaponDamage}", ConsoleColor.Green);
        }
    }
}
