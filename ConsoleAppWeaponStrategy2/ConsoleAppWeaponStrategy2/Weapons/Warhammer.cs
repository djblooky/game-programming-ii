using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeaponStrategy2.Weapons
{
    class Warhammer : Weapon
    {

        public Warhammer()
        {
            this.Damage = 5;
            this.Name = "Warhammer";
            this.Verb = "Swing";
        }
    }
}
