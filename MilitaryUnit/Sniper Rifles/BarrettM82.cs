using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class BarrettM82 : Weapons
    {
        public BarrettM82()
        {
            this.WeaponName = "Barrett M82";
            this.WeaponType = "Sniper Rifle";
            this.WeaponAmmo = ".50 Cal";
            this.WeaponFireRate = "Recoil Operated";
            this.WeaponDamage = "Very High";
        }
    }
}
