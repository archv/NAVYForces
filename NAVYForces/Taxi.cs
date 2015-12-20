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
        /// <summary>
        /// 0 - free, 1 - have free seats, 2 - full
        /// </summary>
        private int status;//in taxi we have 4 seats
        private int speed;
        private int position;
        private List<int> way;
        private List<PassengerInfo> pasInfo;

        Taxi(): this(0){}

        Taxi( int position,int speed=60)
        {
            this.speed = speed;
            this.position = position;
            way = new List<int>(0);
            pasInfo = new List<PassengerInfo>(0);
            status = 0;
        }

        private void pickup(int id)
        {
            if (CanPickUp())
            {
                //getin passenger from list in map and adding to pasinfo new PassengerInfo(how to realize?will see soon)
            }
            switch (pasInfo.Count)
            {
                case 4:
                    status = 2;
                    break;
                default:
                    status = 1;
                    break;

            } 
            Next();
            return;
        }



        private bool CanPickUp()
        {
            if (status < 2) return true;
            return false;
        }


        private void dropOff(int id)
        {
            pasInfo.Remove(pasInfo.Find(x => x.passengerNumber == id));
            //deleting from list in map

            switch (pasInfo.Count)
            {
                case 0:
                    status = 0;
                    break;
                default:
                    status = 1;
                    break;
            } 
            Next();
            return;
        }

        //move to next position
        public void Next()
        {
            if(position!=way.Last())
                position = way[way.Find(x => x == position) + 1];
            return;
        }
    }
}
