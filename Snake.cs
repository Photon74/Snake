using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        private Direction direction;
        private Point nextPoint = new Point(0,0,' ');

        public Snake(Point headPoint, int length, Direction direction)
        {
            this.direction = direction;
            pointsList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(headPoint);
                point.MovePoint(i, direction);
                pointsList.Add(point);
            }
        }

        internal void Move()
        {
            Point tailPoint = pointsList.First();
            pointsList.Remove(tailPoint);
            Point headPoint = GetNextPoint();
            pointsList.Add(headPoint);
            tailPoint.RemovePoint();
            headPoint.DrawPoint();
        }

        private Point GetNextPoint()
        {
            nextPoint = new Point(pointsList.Last());
            nextPoint.MovePoint(1,direction);
            return nextPoint;
        }

        public void GetMovingDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.D:
                    direction = Direction.Right;
                    break;
                case ConsoleKey.W:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.S:
                    direction = Direction.Down;
                    break;
            }
        }

        public bool IsEating(Food food)
        {
            if (nextPoint.X == food.X & nextPoint.Y == food.Y)
            {
                pointsList.Add(nextPoint); //прирост длины змейки на одну точку
                return true;
            }

            return false;
        }

        public bool IsHitItself()
        {
            Point head = pointsList.Last();
            for (int i = 0; i < pointsList.Count - 2; i++)
            {
                if (head.IsPointsCoincide(pointsList[i])) return true;
            }

            return false;
        }

    }


}
