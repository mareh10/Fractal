using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public abstract class Line
    {
        public List<Point> points = new List<Point>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var p in points)
                sb.Append(p.ToString() + ' ');
            return sb.ToString();
        }
    }
}
