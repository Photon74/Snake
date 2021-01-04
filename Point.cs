using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }
        private char Sym { get; set; }

        //public Point() { }
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

        public void DrawPoint()
        {
            Console.SetCursorPosition(X,Y);
            Console.WriteLine(Sym);
        }

        public void RemovePoint()
        {
            Sym = ' ';
            DrawPoint();
        }

        public void MovePoint(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    X += offset;
                    break;
                case Direction.Left:
                    X -= offset;
                    break;
                case Direction.Up:
                    Y -= offset;
                    break;
                case Direction.Down:
                    Y += offset;
                    break;
            }
        }
        public override string ToString()
        {
            return X + ", " + Y + ", " + Sym;
        }
    }
}
