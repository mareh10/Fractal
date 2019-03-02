using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public delegate double CurveFunction(double x);

    public class Curve : Line
    {
        public readonly CurveFunction curveFunction;
        public Curve(Interval interval, CurveFunction f)
        {
            for (double x = interval.start; x <= interval.end; x += Geometry.period)
            {
                points.Add(new Point(x, f(x)));
                curveFunction = f;
            }
        }

        //public Point PointAt(double x)
        //{
        //    return points[x];
        //}
    }
}
