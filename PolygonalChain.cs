using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class PolygonalChain
    {
        public readonly LinkedList<Segment> chain = new LinkedList<Segment>();

        public PolygonalChain(Segment[] segments)
        {
            chain.AddFirst(segments[0]);
            for (int i = 1; i < segments.Length; i++)
            {
                if (chain.Last.Value.end.Equals(segments[i].start))
                    chain.AddLast(segments[i]);
                else throw new ArgumentException("Wrong sequence of Segments");
            }
        }

        public Point[] ToPointArray(double period)
        {
            return chain.
                Select(c => c.ToPointArray(period)).
                SelectMany(s => s).
                ToArray();
        }

        public string ToString(double period)
        {
            var sb = new StringBuilder();
            foreach (var p in this.ToPointArray(period))
                sb.Append(p.ToString() + ' ');
            return sb.ToString();
        }
    }
}
