using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public class FlyDownCommand : Command
    {
        public FlyDownCommand()
        {
            this.CommandName = "Move Up";
        }

        public override void Execute(GameComponent go)
        {
            go.FlyDown();
            base.Execute(go);
        }
    }
}
