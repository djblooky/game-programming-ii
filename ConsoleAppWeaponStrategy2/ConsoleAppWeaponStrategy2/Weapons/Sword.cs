using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeaponStrategy2.Weapons
{
    class Sword : Weapon
    {

        public Sword()
        {
            this.Name = "Sword";
            this.Verb = "Swing";
            this.Damage = 10;
        }
    }
}
