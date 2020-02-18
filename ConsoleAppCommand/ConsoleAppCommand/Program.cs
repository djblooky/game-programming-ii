using System;

namespace ConsoleAppCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;

            GameComponent fakeComponentReciever = new GameComponent();

            while (isPlaying)
            {
                //play game
                Console.Write("Enter a key:");
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


                Console.WriteLine($"x:{fakeComponentReciever.X} y:{fakeComponentReciever.Y}");
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

                    default:
                        Console.WriteLine("IDK that key");
                        break;
                }

                return command;
            }
        }
    }
}
