using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Mission 
    {
        virtual public void MissionRequirements()
        {
            Console.WriteLine($"This mission requires more Marines Go get your buddies");
        }
        virtual public void MissionWeaponRequirements()
        {
            Console.WriteLine($"Bring along some Snipers we are going to need those Cowboys!");
        }
    }
}
