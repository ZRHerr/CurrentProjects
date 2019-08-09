using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameProj
{
    public class Attributes
    {


        public int BonusCargo { get; set; }
        public int BonusFuel { get; set; }
        public int BonusMoney { get; set; }

        public Attributes(int bonusFuel, int bonusMoney, int bonusCargo)
        {
            this.BonusCargo = bonusCargo * 10;
            this.BonusFuel = bonusFuel * 10;
            this.BonusMoney = bonusMoney * 50;

        }
    }
}
