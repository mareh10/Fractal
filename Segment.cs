using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class Segment : Line
    {
        public readonly Point start;
        public readonly Point end;

        public Segment(Point start, Point end)
        {
            this.start = start;
            this.end = end;
            points = this.ToPointList();
        }

        public List<Point> ToPointList()
        {
            var lst = new List<Point>();
            double prop = (end.Y - start.Y) / (end.X - start.X);
            //debug here
            for (double i = 0; i <= end.X - start.X; i += Geometry.period)
            {               
                lst.Add(new Point(i + start.X, (i * prop) + start.Y));
            }
            return lst;
        }
    }
}
