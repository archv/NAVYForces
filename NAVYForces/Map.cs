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
        bool CalculateWay(int from, int to, out List<int> way);
        Passenger GetPassenger(int id);
        int GetPassengerCount();
        Taxi GetTaxi(int id);
        int GetTaxiCount();
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
            taxies.Add(taxi);
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
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

        public int GetPassengerCount()
        {
            return passengers.Count;
        }

        public int GetTaxiCount()
        {
            return taxies.Count;
        }
    }
}
