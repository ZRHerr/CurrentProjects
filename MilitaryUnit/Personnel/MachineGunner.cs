using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MachineGunner : People, IWeaponAssignment
    {
        public MachineGunner()
            {
            Console.WriteLine($"Welome");
            SelectPeople();
            WeaponAssignment();
            }
        
        public override void Train(string a)
        {
            Console.WriteLine($"Fires Blindly due to lack of sleep", ConsoleColor.Green);
        }
        public void WeaponAssignment()
        {
            M240L m240 = new M240L();
            Console.WriteLine($"The Weapon you will have is a {m240.WeaponName}", ConsoleColor.Green);
            Console.WriteLine($"Your Weapon is a {m240.WeaponType}", ConsoleColor.Green);
            Console.WriteLine($"The Weapon uses{m240.WeaponAmmo}", ConsoleColor.Green);
            Console.WriteLine($"It fires {m240.WeaponFireRate}", ConsoleColor.Green);
            Console.WriteLine($"Its Damage Level is {m240.WeaponDamage}", ConsoleColor.Green);
        }
    }
}
