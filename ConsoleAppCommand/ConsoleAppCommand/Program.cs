using System;

namespace ConsoleAppCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;

            GameComponent fakeComponentReciever = new GameComponent();

            Console.Write("\n\tW: move up\tA: move left\tS: move down\tD: move right\tspace: fly up\tZ: fall down");

            while (isPlaying)
            {
                //play game
           
                ConsoleKeyInfo keyI = Console.ReadKey();

                ICommand command = GetCommandFromKey(keyI);
                if (command != null)
                {
                    command.Execute(fakeComponentReciever);
                }
                else
                {
                    Console.WriteLine("Sorry I dont know that command");
                }

                switch (keyI.Key) {
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        isPlaying = false;
                        break;
                }


                Console.WriteLine($"\n\tX:{fakeComponentReciever.X}\tY:{fakeComponentReciever.Y}\tZ:{fakeComponentReciever.Z}");
            }

            static ICommand GetCommandFromKey(ConsoleKeyInfo ki)
            {
                Command command = null;

                switch (ki.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        command = new MoveUpCommand();
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        command = new MoveRightCommand();
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        command = new MoveDownCommand();
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        command = new MoveLeftCommand();
                        break;

                    case ConsoleKey.Spacebar:
                        command = new FlyUpCommand();
                        break;

                    case ConsoleKey.Z:
                        command = new FlyDownCommand();
                        break;

                    default:
                        Console.WriteLine("IDK that key");
                        break;
                }

                return command;
            }
        }
    }
}
