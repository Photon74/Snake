using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point // точка
    {
        public int X { get; private set; } // координата х точки
        public int Y { get; private set; } // координата у точки
        private char Sym { get; set; } // символ, рисующий точку

        protected Point() { }
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

        internal void DrawPoint()
        {
            Console.SetCursorPosition(X,Y);
            Console.WriteLine(Sym);
        }

        internal void RemovePoint()
        {
            Sym = ' ';
            DrawPoint();
        }

        internal void MovePoint(int offset, Direction direction)
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

        internal bool IsCoincide(Point point) // Проверка на совпадение двух точек
        {
            return point.X == X && point.Y == Y;
        }
    }
}
