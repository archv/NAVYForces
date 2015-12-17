using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    interface iMap
    {
        void Next();
        List<int> GetPassengersIdsInPoint(int id);
        List<int> CalculateWay(int from, int to);
        Passenger GetPassenger(int id);
        Taxi GetTaxi(int id);
        void AddTaxi(iTaxi taxi);
        void AddPassenger(iPassenger passenger);
        void AddConnection(int from, int to, bool reverse = true);
        int GetM();
        int GetN();
    }

    class Map: iMap
    {
        private List<Taxi> taxies;
        private List<Passenger> passengers;
        private List<List<int>> connections;
        private int m, n;                   // board size

        public Map() : this(100, 100) { }
        public Map(int m, int n)
        {
            taxies = new List<Taxi>(0);
            passengers = new List<Passenger>(0);
            this.m=m;
            this.n=n;
            connections = new List<List<int>>(m*n);
            for (int i = 0; i < m * n; i++) connections[i] = new List<int>(0);
        }

        public void Next()
        {
            return;
        }

        public List<int> CalculateWay(int from, int to)
        {
            return null;
        }

        public List<int> GetPassengersIdsInPoint(int id)
        {
            return null;
        }

        public Passenger GetPassenger(int id) 
        { return passengers[id]; }
        public Taxi GetTaxi(int id)
        { return taxies[id]; }

        public void AddTaxi(iTaxi taxi)
        {
            taxies.Add((Taxi)taxi);
        }

        public void AddPassenger(iPassenger passenger)
        {
            passengers.Add((Passenger)passenger);
        }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            connections[from].Add(to);
            if (reverse) connections[to].Add(from);
        }

        int GetM()
        {
            return m;
        }

        int GetN()
        {
            return n;
        }
    }
}
