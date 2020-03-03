using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWeaponStrategy.Weapons
{
    public interface IWeapon
    {
        int Damage { get; protected set; }
        string Name { get; protected set; }
        string Verb { get; protected set; }

        void Use();
    }
}
