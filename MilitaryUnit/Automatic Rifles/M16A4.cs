using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M16A4 : Weapons
    {
        public M16A4()
        {
            this.WeaponName = "M16A4";
            this.WeaponType = "Assault Rifle";
            this.WeaponAmmo = "5.56x45mm";
            this.WeaponFireRate = "459RPM";
            this.WeaponDamage = "Medium";
        }
    }
}
