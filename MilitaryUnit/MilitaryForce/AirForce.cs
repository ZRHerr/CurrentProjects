using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class AirForce : MilitaryForce
    {
        public AirForce(string branchName, int region, int personnelCount) : base(branchName, region, personnelCount)
        {

        }
        public override int Region { get => base.Region; set => base.Region = value; }
        public override int PersonnelCount { get => base.PersonnelCount; set => base.PersonnelCount = value; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Branch: {this.BranchName}, Region: {this.Region}, Total Personnel: {this.PersonnelCount}");
            return stringBuilder.ToString();
        }

    }
}

