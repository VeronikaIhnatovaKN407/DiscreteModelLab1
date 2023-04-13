using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Edge : IComparable<Edge>
    {
        public int From { get; }
        public int To { get; }
        public int Weight { get; }

        public Edge(int from, int to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            return Weight.CompareTo(other.Weight);
        }
    }
}
