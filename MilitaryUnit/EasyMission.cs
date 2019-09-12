using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class EasyMission : Mission
    {

        public EasyMission()
        {
            new Infantry();
            Console.WriteLine("GoodLuck!");
        }
        public override void MissionRequirements()
        {
            Console.WriteLine("This is all you could find!");
        }
    }
}
