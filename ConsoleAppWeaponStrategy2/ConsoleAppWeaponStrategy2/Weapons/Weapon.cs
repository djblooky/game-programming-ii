using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeaponStrategy2.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public int Damage { get; protected set; }
        public string Name { get; protected set; }
        public string Verb { get; protected set; }

        public Weapon()
        {
            this.Name = "No Weapon";
            this.Damage = 0;
            this.Verb = "Use";
        }

        public string Use()
        {
            return $"{this.Verb} that {this.Name}";
        }
    }
}
