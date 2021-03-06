﻿using System;
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
        void ClearAll();
    }

    class Map: iMap
    {
        private List<List<int>> connections;
        private int m, n;                       // board size

        public Map() : this(20, 20) { }
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

        public void ClearAll()
        {
            connections = new List<List<int>>(0);
            for (int i = 0; i < m * n; i++) connections.Add(new List<int>(0));
        }

        private bool recursiveCalculate(int from, int to, ref List<int> used, ref List<int> way)
        {
            used.Add(from);
            if (from == to) { way.Insert(0,from); return true; }

            if (connections[from].Count > 0)
                for (int i = 0; i < connections[from].Count; i++)
                {
                    bool pointNotUsed = used.FindIndex(x => x == connections[from][i]) == -1;
                    if (pointNotUsed && recursiveCalculate(connections[from][i], to, ref used, ref way))
                    {
                        way.Insert(0, from);
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
            for (int i = 0; i < connections[from].Count; i++)
                if (connections[from][i] == to) throw new Exception("Связь уже существует.");

            connections[from].Add(to);
            if (reverse) connections[to].Add(from);
        }
    }
}
