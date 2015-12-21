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
        void AddTaxi(Taxi taxi);
        void AddPassenger(Passenger passenger);
        void AddConnection(int from, int to, bool reverse = true);
        int GetM();
        int GetN();
    }

    class Map: iMap
    {
        private List<Taxi> taxies;
        private List<Passenger> passengers;
        private List<List<int>> connections;
        private int m, n;                       // board size

        public Map() : this(100, 100) { }
        public Map(int m, int n)
        {
            taxies = new List<Taxi>(0);
            passengers = new List<Passenger>(0);
            this.m=m;
            this.n=n;
            connections = new List<List<int>>(0);
            for (int i = 0; i < m * n; i++) connections.Add(new List<int>(0));
        }

        public void Next()
        {
            for (int i = 0; i < taxies.Count; i++) taxies[i].Next();
        }

        public List<int> CalculateWay(int from, int to)
        {
            return null;
        }

        public List<int> GetPassengersIdsInPoint(int id)
        {
            List<int> output = new List<int>(0);
            for (int i = 0; i < passengers.Count; i++) if (passengers[i].Position == id) output.Add(i);
            return output;
        }

        public Passenger GetPassenger(int id) 
        { return passengers[id]; }
        public Taxi GetTaxi(int id)
        { return taxies[id]; }

        public void AddTaxi(Taxi taxi)
        {
            taxies.Add((Taxi)taxi);
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add((Passenger)passenger);
        }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            connections[from].Add(to);
            if (reverse) connections[to].Add(from);
        }

        public int GetM()
        {
            return m;
        }

        public int GetN()
        {
            return n;
        }
    }
}
