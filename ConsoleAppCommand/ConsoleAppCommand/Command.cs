using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public abstract class Command : ICommand
    {
        public string CommandName;

        public Command()
        {
            CommandName = "Base COmmand";
        }

        public virtual void Execute(GameComponent go)
        {
            this.Log();
        }

        protected virtual string Log()
        {
            //log basic command to console
            return $"{this.CommandName} executed";
        }

        protected virtual void Log(GameComponent go)
        {
            //log basic command to console
            Console.WriteLine($"{this.Log()} executed on {go.ToString()}");
        }
    }
}
