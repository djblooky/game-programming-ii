using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeaponStrategy2.Weapons
{
    class BFG : Weapon
    {
        public BFG()
        {
            this.Name = "BFG";
            this.Damage = 100;
            this.Verb = "Shoot";
        }
    }
}
