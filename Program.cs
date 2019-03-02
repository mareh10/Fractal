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
            Point[] p =
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(3, 0),
                new Point(4, 5)
            };

            var PC = new PolygonalChain(p, 0.5);
            Console.WriteLine(PC.ToString());
        }
    }
}
