using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    abstract class People
    {
        private string FirstName; 
        private string LastName;
        private string Rank;
        private readonly Random rnd = new Random();

        private readonly string[] rank = {"Private","Private First-Class","Lance Corporal","Corporal",
        "Sergeant","Staff Sergeant","Gunnery Sergeant","Master Sergeant","First Sergeant",
        "MasterGunnery Sergeant","Sergeant Major"};
        private readonly string[] personFirstName = {"Chance", "Lindsey", "Miguel", "Timothy", "Joshua", "Mario",
        "Brandon", "Zachary", "Santana", "Ramu", "Brandon", "Daniel", "Alejandro", "Alexander", "Pharaoh", "Tyler",
        "Kevin", "Jonathan", "Robert", "Michael", "William", "Jay", "Jeffrey", "Stephen", "David", "Tom"};
        private readonly string[] personLastName = {"Alexander","Atkins","Barrera","Eales","Emery","Gomes","Hagerman","Herrera",
        "Jolly","Kc","Lancaster","Leash","Madrigaldiaz","Mancino","Manson","McKee","Pixler","Quick","Schalk",
        "Smith","Staniscia","Steenbergen","ValdexDipre","Vest","White","Williams"};



        public void SelectPeople()
        {
            int RndName = rnd.Next(0, personFirstName.Length - 1);
            this.FirstName = personFirstName.ElementAt(RndName);
            this.LastName = personLastName.ElementAt(RndName);
            this.Rank = rank.ElementAt(rnd.Next(0, rank.Length - 1));
            Console.WriteLine($"{Rank}, {FirstName}, {LastName}");
        }


        public abstract void Train(string a);
        public void Sleep()
        {
            Console.WriteLine("Removes their boots and lays on ISO mat.");
        }
        public void Eat()
        {
            Console.WriteLine("Eats an MRE");
        }
    }
}
