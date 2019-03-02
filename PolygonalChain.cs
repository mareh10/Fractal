using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class PolygonalChain : Line
    {
        public readonly LinkedList<Segment> chain = new LinkedList<Segment>();

        public PolygonalChain(Point[] nodes, double period = 0.01)
        {
            chain.AddFirst(new Segment(nodes[0], nodes[1]));

            for (int i = 1; i < nodes.Length - 1; i++)
            {
                chain.AddLast(new Segment(nodes[i], nodes[i + 1]));
            }
            points = chain.
                Select(c => c.ToPointArray(period)).
                SelectMany(s => s).
                Distinct().
                ToList();
        }
    }
}
