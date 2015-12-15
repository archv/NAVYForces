using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    struct PassengerInfo
    {
        public int destination, passengerNumber;
    }

    interface iTaxi
    {
        void Next();
    }

    class Taxi: iTaxi
    {
        private int status;
        private int speed;
        private int position;
        private List<int> way;
        private List<PassengerInfo> pasInfo;

        Taxi(): this(60, 0){}

        Taxi(int speed, int position)
        {
            this.speed = speed;
            this.position = position;
            way = new List<int>(0);
            pasInfo = new List<PassengerInfo>(0);
            status = 0;
        }

        private void pickup(int id)
        {
            return;
        }

        private void dropOff(int id)
        {
            return;
        }

        //move to next position
        public void Next()
        {
            return;
        }
    }
}
