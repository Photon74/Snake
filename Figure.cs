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

        internal bool IsHittedBy(Figure figure)
        {
            return pointsList.Any(figure.IsHittedBy);
        }

        private bool IsHittedBy(Point anotherPoint)
        {
            return pointsList.Any(point => point.IsCoincide(anotherPoint));
        }
    }
}
