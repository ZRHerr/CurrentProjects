using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Platoon : People, IWeaponAssignment
    {
        public void GetInfo()
        {
            Console.WriteLine("What is your name Marine!");
            SelectPeople();
            Console.ReadLine();
            Console.WriteLine("Would you like to continue with this Marine? Y/N");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                return;
            }
            else if (answer == 'n' || answer == 'N')
            {
                GetInfo();
            }
            else
            {
                Console.WriteLine("Please enter Y/N.");
                GetInfo();
            }
        }
        public override void Train(string a)
        {
            Console.WriteLine($"Goes to the field");
        }

        public void WeaponAssignment()
        {
            M27_IAR m27 = new M27_IAR();
            Console.WriteLine($"The Weapon you will have is a {m27.WeaponName}", ConsoleColor.Cyan);
            Console.WriteLine($"Your Weapon is a {m27.WeaponType}", ConsoleColor.Cyan);
            Console.WriteLine($"The Weapon uses{m27.WeaponAmmo}", ConsoleColor.Cyan);
            Console.WriteLine($"It fires {m27.WeaponFireRate}", ConsoleColor.Cyan);
            Console.WriteLine($"Its Damage Level is {m27.WeaponDamage}", ConsoleColor.Cyan);
        }
    }
}
