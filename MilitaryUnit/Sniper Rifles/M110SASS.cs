using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M110SASS : Weapons
    {
        public M110SASS()
        {
            this.WeaponName = "M110 Semi-Automatic Sniper System";
            this.WeaponType = "Sniper Rifle";
            this.WeaponAmmo = "7.62x51mm";
            this.WeaponFireRate = "As fast as you can pull the trigger";
            this.WeaponDamage = "Medium";
        }
    }
}
