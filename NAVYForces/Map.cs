using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    interface iMap
    {
        bool CalculateWay(int from, int to, out List<int> way);
        void AddConnection(int from, int to, bool reverse = true);
        int M { get; }
        int N { get; }
        List<List<int>> Connections { get; }
    }

    class Map: iMap
    {
        private List<List<int>> connections;
        private int m, n;                       // board size

        public Map() : this(100, 100) { }
        public Map(int m, int n)
        {
            this.m=m;
            this.n=n;
            connections = new List<List<int>>(0);
            for (int i = 0; i < m * n; i++) connections.Add(new List<int>(0));
        }

        public bool CalculateWay(int from, int to, out List<int> way)
        {
            way = new List<int>(0);
            var tmp = new List<int>(0);
            var used = new List<int>(0);
            return recursiveCalculate(from, to, ref used, ref way);
        }

        private bool recursiveCalculate(int from, int to, ref List<int> used, ref List<int> way)
        {
            used.Add(from);
            if (from == to) { way.Add(from); return true; }

            if (connections[from].Count > 0)
                for (int i = 0; i < connections[from].Count; i++)
                {
                    bool test = used.FindIndex(x => x == connections[from][i]) == -1;
                    if (test && recursiveCalculate(connections[from][i], to, ref used, ref way))
                    {
                        way.Add(from);
                        return true;
                    }
                }            
        
            return false;
        }

        public int M { get { return m; } }
        public int N { get { return n; } }
        public List<List<int>> Connections { get { return connections; } }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            connections[from].Add(to);
            if (reverse) connections[to].Add(from);
        }
    }
}
