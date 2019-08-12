using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MK48 : Weapons
    {
        public MK48()
        {
            this.WeaponName = "Mark 48";
            this.WeaponType = "Machine Gun";
            this.WeaponAmmo = "7.62x51mm";
            this.WeaponFireRate = "600RPM";
            this.WeaponDamage = "Heavy";
        }
    }
}
