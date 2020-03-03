using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeaponStrategy2.Weapons
{
    public interface IWeapon
    {
        int Damage { get;  }
        string Name { get; }
        string Verb { get; }

        string Use();
    }
}
