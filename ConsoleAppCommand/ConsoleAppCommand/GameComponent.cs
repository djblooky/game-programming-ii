using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand
{
    public class GameComponent
    {
        protected int _X = 0, _Y = 0, _Z = 0;

        public int X
        {
            get { return this._X; }
            protected set { _X = value; }
        }

        public int Y
        {
            get { return this._Y; }
            protected set { _Y = value; }
        }

        public int Z
        {
            get { return this._Z; }
            protected set { _Z = value; }
        }

        internal void FlyUp()
        {
            Z++;
        }

        internal void FlyDown()
        {
            Z--;
        }

        internal void MoveUp()
        {
            this.Y++;
        }

        internal void MoveRight()
        {
            this.X++;
        }

        internal void MoveDown()
        {
            this.Y--;
        }

        internal void MoveLeft()
        {
            this.X--;
        }
    }
}
