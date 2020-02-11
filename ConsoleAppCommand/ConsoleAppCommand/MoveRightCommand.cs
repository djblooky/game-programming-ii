using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
     class MoveRightCommand : Command
    {
        public MoveRightCommand()
        {
            this.CommandName = "MOve Right";
        }

        public override void Execute(GameComponent go)
        {
            go.MoveRight(); //hard association
            base.Execute(go);
        }
    }
}
