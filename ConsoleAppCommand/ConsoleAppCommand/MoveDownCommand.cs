using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public class MoveDownCommand : Command
    {
        public MoveDownCommand()
        {
            this.CommandName = "Move Down";
        }

        public override void Execute(GameComponent go)
        {
            go.MoveDown();
            base.Execute(go);
        }
    }
}
