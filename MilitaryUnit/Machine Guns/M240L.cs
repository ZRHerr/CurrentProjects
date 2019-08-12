using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M240L : Weapons
    {
        public M240L()
        {
            this.WeaponName = "M240 Lima";
            this.WeaponType = "Machine Gun";
            this.WeaponAmmo = "7.62x51mm";
            this.WeaponFireRate = "650RPM";
            this.WeaponDamage = "Heavy";
        }
    }
}
