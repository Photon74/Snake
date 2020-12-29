using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point headPoint, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(headPoint);
                point.Move(i, direction);
                pointsList.Add(point);
            }
        }
    }
}
