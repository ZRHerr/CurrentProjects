using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Remington870 : Weapons
    {
        public Remington870()
        {
            this.WeaponName = "Remington Model 870";
            this.WeaponType = "Shotgun";
            this.WeaponAmmo = "12 Gauge";
            this.WeaponFireRate = "Pump Action";
            this.WeaponDamage = "Heavy";
        }
    }
}
