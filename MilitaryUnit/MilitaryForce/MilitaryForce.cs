using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MilitaryForce
    {

        private string branchName;
        private int region;
        private int personnelCount;

        public MilitaryForce(string branchName, int region, int personnelCount)
        {
            this.branchName = branchName;
            this.region = region;
            this.personnelCount = personnelCount;
        }

        public virtual string BranchName
        {
            get
            {
                return this.branchName;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                this.branchName = value;
            }
        }

        public virtual int Region
        {
            get
            {
                return this.region;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please enter a positive number");
                }
                this.region = value;
            }
        }

        public virtual int PersonnelCount
        {
            get
            {
                return this.personnelCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please enter a positive number");
                }
                this.personnelCount = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Branch: {0}, Region: {1}, Total Personnel: {2}",
                this.branchName,
                this.region,
                this.personnelCount));
            return stringBuilder.ToString();
        }

    }
}
