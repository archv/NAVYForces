// what?
//nothing
//лолик
//hi

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
        private int nope;
    }

    struct mapPoint
    {
        public string name;
        public int x, y;
    }

    interface iMap
    {
        void Next();
        List<int> GetPassengersIdsInPoint(int id);
        List<int> CalculateWay(int from, int to);
        Passenger GetPassenger(int id);
    }

    class Map: iMap
    {
        private List<Taxi> taxies;
        private List<Passenger> passengers;
        private List<mapConnection> connections;
        private List<mapPoint> points;

        Map()
        {
            taxies = new List<Taxi>(0);
            passengers = new List<Passenger>(0);
            points = new List<mapPoint>(0);
            connections = new List<mapConnection>(0);
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
    }

   
}
