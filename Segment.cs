using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class Segment
    {
        public readonly Point start;
        public readonly Point end;

        public Segment(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public Point[] ToPointArray(double period)
        {
            var lst = new List<Point>();
            double prop = end.Y - start.Y / end.X - start.X;
            //debug here
            for (double i = start.X; i <= end.X; i += period)
            {               
                lst.Add(new Point(i, (i * prop) + start.Y));
            }
            return lst.ToArray();
        }
    }
}
