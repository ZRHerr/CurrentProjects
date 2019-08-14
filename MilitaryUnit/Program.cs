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
            Console.WriteLine("\r\nGear up we got a mission!");

            Platoon plt = new Platoon();
                plt.GetInfo();
            Console.ReadLine();


            Console.WriteLine("Lets review the mission details\r\n" +
                "1: Easy Mission\r\n" +
                "2: Hard Mission");
            int missionChoice = int.Parse(Console.ReadLine());
            if(missionChoice == 1)
            {
                EasyMission EM = new EasyMission();
                EM.MissionRequirements();
                
            }
            else if(missionChoice == 2)
            {
                HardMission HM = new HardMission();
                HM.MissionWeaponRequirements();
            }



            

            marineChoice:
            Console.WriteLine("Colors Begins to play!\r\n" +
                "Sir, I think I need another person or two to bring along with.\r\n" +
                "1:: Bring a MachineGunner\r\n" +
                "2:: Bring a good ole fashion 0311\r\n" +
                "3:: Bring a scout sniper");
            int studentChoice = int.Parse(Console.ReadLine());
            switch (studentChoice)
            {
                case 1:
                    MachineGunner gunner = new MachineGunner();
                    gunner.WeaponAssignment();
                    break;
                case 2:
                    Infantry infantry2 = new Infantry();
                   infantry2.WeaponAssignment();
                    break;
                case 3:
                    ScoutSniper sniper = new ScoutSniper();
                    sniper.WeaponAssignment();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\r\nShould we bring anyone else? Y/N");
            string restartChoice = Console.ReadLine();
            switch (restartChoice)
            {
                case "y":
                    goto marineChoice;
                case "Y":
                    goto marineChoice;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            selectTrain:
            Console.WriteLine("\r\nLets get some quick training in\r\n" +
                "1:: Train the MachineGunner\r\n" +
                "2:: Train the Infantryman\r\n" +
                "3:: Train the sniper");
            int TrainChoice = int.Parse(Console.ReadLine());

            switch (TrainChoice)
            {
                case 1:
                    MachineGunner gunner = new MachineGunner();
                    Console.Clear();
                    gunner.Train(gunner.ToString());
                    break;

                case 2:
                    Infantry infantry2 = new Infantry();
                    Console.Clear();
                    infantry2.Train(infantry2.ToString());
                    break;

                case 3:
                    ScoutSniper sniper = new ScoutSniper();
                    Console.Clear();
                    sniper.Train(sniper.ToString());
                    break;

                default:
                    break;
            }
            Console.WriteLine("\r\nTraining complete (Well that was useful)\r\n\r\n" +
                "Should we train some more or do you think we are good? Y/N");
            string restartTrain = Console.ReadLine();
            switch (restartTrain)
            {
                case "y":
                    goto selectTrain;
                case "Y":
                    goto selectTrain;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            Console.WriteLine("Well it could have been better, but I guess we're done here");
            plt.Eat();
            plt.Sleep();
            Console.ReadLine();
        }
    }
}
