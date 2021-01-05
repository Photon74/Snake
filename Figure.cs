using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure : Point
    {
        protected List<Point> pointsList;
        public void Draw()
        {
            foreach (Point point in pointsList)
            {
                point.DrawPoint();
            }
        }

        internal bool IsHitedBy(Figure figure)
        {
            foreach (Point point in pointsList)
            {
                if (figure.IsHitedBy(point)) return true;
            }

            return false;
        }

        private bool IsHitedBy(Point head)
        {
            foreach (Point point in pointsList)
            {
                if (point.IsPointsCoincide(head)) return true;
            }

            return false;
        }
    }
}
