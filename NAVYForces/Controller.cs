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
        void AddTaxi(iTaxi taxi);
        void AddPassenger(iPassenger passenger);
        void AddConnection(int from, int to, bool reverse = true);
    }

    class Controller:iController
    {
        private Map map;

        public Controller()
        {
            map = new Map();
        }

        public void DrawMap()
        {
            
        }

        public void AddTaxi(iTaxi taxi)
        {
            map.AddTaxi(taxi);
        }

        public void AddPassenger(iPassenger passenger)
        {
            map.AddPassenger(passenger);
        }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            map.AddConnection(from, to, reverse);
        }
    }
}
