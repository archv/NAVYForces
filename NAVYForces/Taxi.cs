using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    static class Constants
    {
        public const double MAXPASSENGERS = 4;          
    }

    class PassengerInfo
    {
        public int destination, id;
        public PassengerInfo(int dest, int id) { destination = dest; this.id = id; }
    }

    interface iTaxi
    {
        void Next();
        int Position { get; }
        int Destination { get; }
    }

    public class Taxi : iTaxi
    {             
        private int speed;
        private int position;
        private List<int> way;
        private List<PassengerInfo> pasInfo;

        public Taxi() : this(0) { }

        public Taxi(int position, int speed = 60)
        {
            this.speed = speed;
            this.position = position;
            way = new List<int>(0);
            pasInfo = new List<PassengerInfo>(0);
        }
        public int Position { get { return position; } }
        public int Destination { get { if (way.Count > 0) return way[0]; else return -1; } }
        private void pickup(int id)              // id from Map array
        {
            pasInfo.Add(new PassengerInfo(Program.FController.GetPassenger(id).Destination,id));
            Program.FController.GetPassenger(id).Status = PassengerStatus.InCar;
        }

        private void dropOff(int id)            // id from pasInfo array
        {
            Program.FController.GetPassenger(pasInfo[id].id).Status = PassengerStatus.Arrived;
            pasInfo.RemoveAt(id);
        }

        // Move to the next position
        public void Next()
        {            
            if (way.Count < 2)
            if (pasInfo.Count > 0) Program.FController.CalculateWay(position, pasInfo[0].destination, out way); 
            else
                way = Program.FController.GetWayToClosestPass(position);
            

            if (way.Count > 1)
            {
                position = way[way.Count - 2];
                way.RemoveAt(way.Count-1);
            }
            
                // drop off arrived passengers
            for (int i = 0; i < pasInfo.Count; i++)
            {
                Program.FController.GetPassenger(pasInfo[i].id).Position = position;
                if (pasInfo[i].destination == position) dropOff(i);
            }

                // puckup if avaliable
            if (pasInfo.Count < Constants.MAXPASSENGERS)
            {
                List<int> avaliablePass = Program.FController.GetPassengersIdsInPoint(position);
                for (int i = 0; i < avaliablePass.Count; i++)
                    if (pasInfo.Count == Constants.MAXPASSENGERS) break;
                    else if ((Program.FController.GetPassenger(avaliablePass[i]).Status == PassengerStatus.OnStreet) ||
                             (Program.FController.GetPassenger(avaliablePass[i]).Status == PassengerStatus.Idle))
                        pickup(avaliablePass[i]);
            }
        }
    }
}
