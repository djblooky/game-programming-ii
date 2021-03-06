﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public class MoveUpCommand : Command
    {
        public MoveUpCommand()
        {
            this.CommandName = "Move Up";
        }

        public override void Execute(GameComponent go)
        {
            go.MoveUp();
            base.Execute(go);
        }
    }
}
