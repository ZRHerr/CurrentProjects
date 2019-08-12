using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class AverageStudent : People, IWeaponAssignment
    {
        public override void Study(string a)
        {
            Console.WriteLine($"The Student Is working on Military Units Assignment", ConsoleColor.Yellow);
        }
        public override void Test(string a)
        {
            Console.WriteLine($"The Student is an average student", ConsoleColor.Yellow);
        }
        public void WeaponAssignment()
        {
           M240L m240 = new M240L();
            Console.WriteLine($"The Weapon you will have is a {m240.weaponName}", ConsoleColor.Yellow);
            Console.WriteLine($"Your weapon is a {m240.weaponType}", ConsoleColor.Yellow);
            Console.WriteLine($"The weapon uses{m240.weaponAmmo}", ConsoleColor.Yellow);
            Console.WriteLine($"It fires {m240.weaponFireRate}", ConsoleColor.Yellow);
            Console.WriteLine($"Its Damage Level is {m240.weaponDamage}", ConsoleColor.Yellow);
        }
    }
}
