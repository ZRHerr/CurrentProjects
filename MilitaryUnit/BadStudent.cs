using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class BadStudent : People, IWeaponAssignment
    {
        public override void Study(string a)
        {
            Console.WriteLine($"The Student is still working on the MathApp", ConsoleColor.Red);
        }
        public override void Test(string a)
        {
            Console.WriteLine($"The Student is probably going to fail", ConsoleColor.Red);
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