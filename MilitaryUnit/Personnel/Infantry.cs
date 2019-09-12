using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Infantry : People, IWeaponAssignment
    {
        public Infantry()
        {
            Console.WriteLine($"Welome");
            SelectPeople();
            WeaponAssignment();
        }
        public override void Train(string a)
        {
            Console.WriteLine($"Goes to the field and runs out of cigarrettes", ConsoleColor.Red);
        }
        public void WeaponAssignment()
        {
            M16A4 m16 = new M16A4();
            Console.WriteLine($"The Weapon you will have is a {m16.WeaponName}", ConsoleColor.Red);
            Console.WriteLine($"Your weapon is a {m16.WeaponType}", ConsoleColor.Red);
            Console.WriteLine($"The weapon uses{m16.WeaponAmmo}", ConsoleColor.Red);
            Console.WriteLine($"It fires {m16.WeaponFireRate}", ConsoleColor.Red);
            Console.WriteLine($"Its Damage Level is {m16.WeaponDamage}", ConsoleColor.Red);
        }
    }
}