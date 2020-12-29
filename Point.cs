using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int X { get; }
        private int Y { get; }
        private char Sym { get; }

        public Point() { }
        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }
        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Sym = point.Sym;
        }

        public void Move(int distance, Direction direction)
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.WriteLine(Sym);
        }
    }
}
