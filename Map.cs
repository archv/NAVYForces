using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    struct mapConnection
    {
        public int point1, point2, length;
    }

    struct mapPoint
    {
        public int x, y;
    }

    interface iMap
    {
        void Next();
        List<int> GetPassengersIdsInPoint(int id);
        List<int> CalculateWay(int from, int to);
        Passenger GetPassenger(int id);
        mapPoint GetPoint(int num);
    }

    class Map: iMap
    {
        private List<Taxi> taxies;
        private List<Passenger> passengers;
        private List<List<int>> connections;

        Map()
        {
            taxies = new List<Taxi>(0);
            passengers = new List<Passenger>(0);
            connections = new List<List<int>>(0);
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

        public mapPoint GetPoint(int num)
        {
            return new mapPoint();
        }

        public Passenger GetPassenger(int id) 
        { return passengers[id]; }
    }

   
}
