using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class DisjointSet
    {
        private int[] parent;
        private int[] rank;

        public DisjointSet(int size)
        {
            parent = new int[size];
            rank = new int[size];

            for (int i = 0; i < size; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int Find(int i)
        {
            if (parent[i] == i)
            {
                return i;
            }
            else
            {
                parent[i] = Find(parent[i]);
                return parent[i];
            }
        }

        public void Union(int i, int j)
        {
            int root1 = Find(i);
            int root2 = Find(j);

            if (root1 == root2)
            {
                return;
            }

            if (rank[root1] < rank[root2])
            {
                parent[root1] = root2;
            }
            else if (rank[root1] > rank[root2])
            {
                parent[root2] = root1;
            }
            else
            {
                parent[root2] = root1;
                rank[root1]++;
            }
        }
    }
}
