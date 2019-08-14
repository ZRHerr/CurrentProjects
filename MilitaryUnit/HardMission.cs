using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class HardMission : Mission
    {
        public HardMission()
        {
            ScoutSniper scout = new ScoutSniper();
            Console.WriteLine("GoodLuck!");
        }
        public override void MissionRequirements()
        {
            Console.WriteLine("He should be quite helpful!");
        }
    }
}