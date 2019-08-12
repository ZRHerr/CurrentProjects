using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Mossberg590 : Weapons
    {
        public Mossberg590()
        {
            this.WeaponName = "Mossberg 500 series";
            this.WeaponType = "Shotgun";
            this.WeaponAmmo = "12Gauge";
            this.WeaponFireRate = "Pump Action";
            this.WeaponDamage = "Heavy";
        }
    }
}
