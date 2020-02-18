using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public class FlyUpCommand : Command
    {
        public FlyUpCommand()
        {
            this.CommandName = "Fly Up";
        }

        public override void Execute(GameComponent go)
        {
            go.FlyUp();
            base.Execute(go);
        }
    }
}
