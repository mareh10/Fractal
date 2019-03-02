using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Segment[] s = {
                new Segment(new Point(0, 0), new Point(1, 1)),
                new Segment(new Point(1, 1), new Point(3, 0)),
                new Segment(new Point(3, 0), new Point(4, 5))
            };

            var PC = new PolygonalChain(s);
            Console.WriteLine(PC.ToString(0.5));
        }
    }
}
