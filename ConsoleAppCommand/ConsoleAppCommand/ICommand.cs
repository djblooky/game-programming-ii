using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    interface ICommand
    {
        void Execute(GameComponent go);
    }
}
