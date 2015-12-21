using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    interface iController
    {
        void DrawMap();
        void AddTaxi(Taxi taxi);
        void AddPassenger(Passenger passenger);
        void AddConnection(int from, int to, bool reverse = true);
        Taxi GetTaxi(int id);
        Passenger GetPassenger(int id);
        List<int> GetPassengersIdsInPoint(int id);
    }

    public class Controller:iController
    {
        private Map map;

        public Controller()
        {
            map = new Map();
        }

        public void DrawMap()
        {
            
        }

        public void AddTaxi(Taxi taxi)
        {
            map.AddTaxi(taxi);
        }

        public void AddPassenger(Passenger passenger)
        {
            map.AddPassenger(passenger);
        }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            map.AddConnection(from, to, reverse);
        }

        public Taxi GetTaxi(int id)
        {
            return map.GetTaxi(id);
        }

        public Passenger GetPassenger(int id)
        {
            return map.GetPassenger(id);
        }

        public List<int> GetPassengersIdsInPoint(int id)
        {
            return map.GetPassengersIdsInPoint(id);
        }
    }
}
