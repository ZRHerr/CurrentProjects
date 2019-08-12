using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Classroom : People, IWeaponAssignment
    {
        
        public override void Study(string a)
        {
            Console.WriteLine($"The {a} attemps to rotate and Array.");
        }
        public override void Test(string a)
        {
            Console.WriteLine($"The {a} has room for improvement");
        }

        public void WeaponAssignment()
        {
            M27_IAR m27 = new M27_IAR();
            Console.WriteLine($"The Weapon you will have is a {m27.weaponName}", ConsoleColor.Cyan);
            Console.WriteLine($"Your weapon is a {m27.weaponType}", ConsoleColor.Cyan);
            Console.WriteLine($"The weapon uses{m27.weaponAmmo}", ConsoleColor.Cyan);
            Console.WriteLine($"It fires {m27.weaponFireRate}", ConsoleColor.Cyan);
            Console.WriteLine($"Its Damage Level is {m27.weaponDamage}", ConsoleColor.Cyan);
        }
    }
}
