using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M27_IAR : Weapons
    {
        public M27_IAR()
        {
            this.WeaponName = "M27 Infantry Automatic Rifle";
            this.WeaponType = "Assault Rifle";
            this.WeaponAmmo = "5.56x45mm";
            this.WeaponFireRate = "705RPM";
            this.WeaponDamage = "Medium";
        }


    }
}
