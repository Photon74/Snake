using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawInterface();

            Point point = new Point(5, 5, '*');
            Snake snake = new Snake(point, 4, Direction.Right);

            Console.ReadLine();
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
            upLine.DrawPoints();
            downLine.DrawPoints();
            leftLine.DrawPoints();
            rightLine.DrawPoints();
        }
    }
}
