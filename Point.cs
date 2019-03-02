using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point Copy()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return string.Format("({0}; {1})", X, Y);
        }

        public override bool Equals(object obj)
        {
            return (obj as Point).X == X && (obj as Point).Y == Y;
        }
    }
}
