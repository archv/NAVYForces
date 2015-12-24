using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    interface iPassenger
    {
        PassengerStatus Status { get; set; }
        int Destination { get; }
        int Position { get; set; }
    }

    public enum PassengerStatus { Idle, OnStreet, InCar, Arrived };

    public class Passenger : iPassenger
    {
        private int destination;
        private int startPosition;
        private int position;
        private PassengerStatus status;

        public Passenger(int startPosition, int destination, PassengerStatus status = PassengerStatus.Idle)
        {
            this.startPosition = startPosition;
            this.destination = destination;
            position = startPosition;
            this.status = status;  
        }

        public PassengerStatus Status { get { return status; } set { status = value; } }
        public int Destination { get { return destination; } }
        public int Position { get { return position; } set { position = value; } }
    }
}
