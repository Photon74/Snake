using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawInterface();

            Point point = new Point(4, 5, '*');
            Snake snake = new Snake(point, 4, Direction.Right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.A: snake.direction = Direction.Left;
                            break;
                        case ConsoleKey.D: snake.direction = Direction.Right;
                            break;
                        case ConsoleKey.W: snake.direction = Direction.Up;
                            break;
                        case ConsoleKey.S: snake.direction = Direction.Down;
                            break;
                    }
                }
                Thread.Sleep(300);
                snake.Move();
            }
        }

        public static void DrawInterface()
        {
            Console.SetWindowSize(80, 26);
            Console.SetBufferSize(80, 26);
            Console.CursorVisible = false;


            HorizontLine upLine = new HorizontLine(0, 78, 0, '+');
            HorizontLine downLine = new HorizontLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }
    }
}
