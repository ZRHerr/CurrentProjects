using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class SIG_SauerM11 : Weapons
    {
        public SIG_SauerM11()
        {
            this.WeaponName = "SIG Sauer P228";
            this.WeaponType = "Handgun";
            this.WeaponAmmo = "9mm";
            this.WeaponFireRate = "As fast as you can pull the trigger";
            this.WeaponDamage = "Light";
        }
    }
}
