using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class Interval
    {
        public readonly double start;
        public readonly double end;

        public Interval(double start, double end)
        {
            if (start < end)
            {
                this.start = start;
                this.end = end;
            }
            else
            {
                this.end = start;
                this.start = end;
            }
        }

        public double Center { get { return (start + end) / 2; } }

        public double Length { get { return end - start; } }
    }
}
