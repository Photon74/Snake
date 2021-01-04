using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
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
            Point nextPoint = new Point(pointsList.Last());
            nextPoint.MovePoint(1,direction);
            return nextPoint;
        }
    }
}
