using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public delegate double CurveFunction(double x);

    public class Curve
    {
        private Dictionary<double, Point> points = new Dictionary<double, Point>();

        public Curve(Interval interval, CurveFunction f, double period = 0.01)
        {
            for (double x = interval.start; x <= interval.end; x += period)
            {
                points.Add(x, new Point(x, f(x)) );
            }
        }

        public Curve(double start, double end, Segment[] segments, double interval = 0.01)
        {

        }

        public Point PointAt(double x)
        {
            return points[x];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var p in points.Values)
                sb.Append(p.ToString() + ' ');

            return sb.ToString();
        }
    }
}
