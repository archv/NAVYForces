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
        int GetPassengerCount();
        void AddConnection(int from, int to, bool reverse = true);
        Taxi GetTaxi(int id);
        int GetTaxiCount();
        Passenger GetPassenger(int id);
        List<int> GetPassengersIdsInPoint(int id);
    }

    public class Controller:iController
    {
        private Map map;

        public Controller()
        {
            map = new Map();

            // Debug code! Delete!
        /*    map.AddConnection(2, 5);
            map.AddConnection(5, 8);
            map.AddConnection(8, 6);
            map.AddConnection(6, 15);
            map.AddConnection(15, 22);
            map.AddConnection(22, 48);
            map.AddConnection(48, 3);
            map.AddConnection(22, 3);

            List<int> way;

            map.CalculateWay(2, 3, out way);*/
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

        public int GetPassengerCount()
        {
            return map.GetPassengerCount();
        }

        public int GetTaxiCount()
        {
            return map.GetTaxiCount();
        }
    }
}
