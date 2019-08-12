using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class BerettaM9 : Weapons
    {
        public BerettaM9()
        {
            this.WeaponName = "Beretta 9mm pistol";
            this.WeaponType = "Handgun";
            this.WeaponAmmo = "9mm";
            this.WeaponFireRate = "As Fast as you can pull the trigger";
            this.WeaponDamage = "Light";
        }

    }
}
