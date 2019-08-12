using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    abstract class People
    {
        private string firstName; 
        private string lastName;
        private string Rank;


        public string[] personFirstName = {"Chance", "Lindsey", "Miguel", "Timothy", "Joshua", "Mario",
        "Brandon", "Zachary", "Santana", "Ramu", "Brandon", "Daniel", "Alejandro", "Alexander", "Pharaoh", "Tyler",
        "Kevin", "Jonathan", "Robert", "Michael", "William", "Jay", "Jeffrey", "Stephen", "David", "Tom"};
        public string[] personLastName = {"Alexander","Atkins","Barrera","Eales","Emery","Gomes","Hagerman","Herrera",
        "Jolly","Kc","Lancaster","Leash","Madrigaldiaz","Mancino","Manson","McKee","Pixler","Quick","Schalk",
        "Smith","Staniscia","Steenbergen","ValdexDipre","Vest","White","Williams"};
        public string[] rank = {"Private","Private First-Class","Lance Corporal","Corporal",
        "Sergeant","Staff Sergeant","Gunnery Sergeant","Master Sergeant","First Sergeant",
        "MasterGunnery Sergeant","Sergeant Major"};

        public void GetInfo()
        {
            Random rnd = new Random();
            int rndName = rnd.Next(0, personFirstName.Length - 1);
            Console.WriteLine("What is your name Marine!");
            firstName = personFirstName.ElementAt(rndName);
            lastName = personLastName.ElementAt(rndName);
            Console.WriteLine($"My name is {firstName}, {lastName}! Sir!");
            int rndRank = rnd.Next(0, rank.Length - 1);
            Console.WriteLine("What is your rank!");
            Rank = rank.ElementAt(rndRank);
            Console.WriteLine($"\"sweating profusely\"{firstName} says, My rank is {Rank}, Sir!");
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
        public abstract void Train(string a);
        public void Sleep()
        {
            Console.WriteLine($"{rank}\t{firstName},{lastName} Removes their boots and lays on ISO mat.");
        }
        public void Eat()
        {
            Console.WriteLine($"{rank}\t{firstName},{lastName} Eats an MRE");
        }
    }
}
