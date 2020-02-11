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

                switch (keyI.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        fakeComponentReciever.MoveUp();
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        fakeComponentReciever.MoveRight();
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        fakeComponentReciever.MoveDown();
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        fakeComponentReciever.MoveLeft();
                        break;


                    default:
                        Console.WriteLine("IDK that key");
                            break;
                }
                Console.WriteLine($"x:{fakeComponentReciever.X} y:{fakeComponentReciever.Y}");
            }
        }
    }
}
