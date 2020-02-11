using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public interface ICommand
    {
        public void Execute(GameComponent go);
    }
}
