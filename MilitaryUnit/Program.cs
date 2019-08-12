using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nLet's meet some MSSA Marines.");
            Infantry bad = new Infantry();
            bad.GetInfo();

            studentChoice:
            Console.WriteLine("Colors Begins to play!\r\n" +
                "Sir, I think these Marines Need weapons during this course, Just to ensure they stay proficient with it.\r\n" +
                "1:: Give this student a Sniper\r\n" +
                "2:: Give this student a M16\r\n" +
                "3:: Give this student an M240");
            int studentChoice = int.Parse(Console.ReadLine());
            switch (studentChoice)
            {
                case 1:
                    MachineGunner goodStudent = new MachineGunner();
                    goodStudent.WeaponAssignment();
                    break;
                case 2:
                    Infantry BadStudent = new Infantry();
                    BadStudent.WeaponAssignment();
                    break;
                case 3:
                    ScoutSniper AverageStudent = new ScoutSniper();
                    AverageStudent.WeaponAssignment();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\r\nShould we give them a different weapon? Y/N");
            string restartChoice = Console.ReadLine();
            switch (restartChoice)
            {
                case "y":
                    goto studentChoice;
                case "Y":
                    goto studentChoice;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            selectTest:
            Console.WriteLine("\r\nHeres their evaluations, Sir! What type of student should we breif the commander they are?\r\n" +
                "1:: Evaluate as a good student\r\n" +
                "2:: Evaluate as a bad student\r\n" +
                "3:: Evaluate as a average student");
            int TestChoice = int.Parse(Console.ReadLine());

            switch (TestChoice)
            {
                case 1:
                    Platoon platoon = new Platoon();
                    platoon.Train(platoon.ToString());
                    break;

                case 2:
                    Infantry infantry = new Infantry();
                    infantry.Train(infantry.ToString());
                    break;

                case 3:
                    ScoutSniper sniper = new ScoutSniper();
                    sniper.Train(sniper.ToString());
                    break;

                default:
                    break;
            }
            Console.WriteLine("\r\nThe Commander has been breifed.\r\n\r\n" +
                "Should we submit a new breif on this student? Y/N");
            string restartTest = Console.ReadLine();
            switch (restartTest)
            {
                case "y":
                    goto selectTest;
                case "Y":
                    goto selectTest;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            Console.WriteLine("Okay you can leave now!");
            bad.Eat();
            bad.Sleep();
        }
    }
}
