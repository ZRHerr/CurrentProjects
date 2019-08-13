using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Platoon : People, IWeaponAssignment
    {
        public new void GetInfo()
        {
            Random rnd = new Random();
            int rndName = rnd.Next(0, personFirstName.Length - 1);
            Console.WriteLine("What is your name Marine!");
            string first = personFirstName.ElementAt(rndName);
            string last = personLastName.ElementAt(rndName);
            Console.WriteLine($"My name is {first}, {last}! Sir!");
            Console.ReadLine();
            int rndRank = rnd.Next(0, rank.Length - 1);
            Console.WriteLine("What is your rank!");
           string rnk = rank.ElementAt(rndRank);
            Console.WriteLine($"\"sweating profusely\"{first} says, My rank is {rnk}, Sir!");
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
            Console.WriteLine($"The Weapon you will have is a {m27.weaponName}", ConsoleColor.Cyan);
            Console.WriteLine($"Your weapon is a {m27.weaponType}", ConsoleColor.Cyan);
            Console.WriteLine($"The weapon uses{m27.weaponAmmo}", ConsoleColor.Cyan);
            Console.WriteLine($"It fires {m27.weaponFireRate}", ConsoleColor.Cyan);
            Console.WriteLine($"Its Damage Level is {m27.weaponDamage}", ConsoleColor.Cyan);
        }
    }
}
