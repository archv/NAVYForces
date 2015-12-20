using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVYForces
{
    interface iPassenger
    {
        void SetStatus(int value);
        int GetStatus();
        int GetDestination();
        int GetPosition();
    }

    class Passenger: iPassenger
    {
        private int destination;
        private int startPosition;
        private int position;
        /// <summary>
        /// -1-idle, 0-on street, 1-in car, 2-arrived
        /// </summary>
        private int status;

        Passenger(int startPosition, int destination, int status = 0)
        {
            this.startPosition = startPosition;
            this.destination = destination;
            position = startPosition;
            this.status = status;  
            //TODO 1
        }

        public void SetStatus(int value)
        {
            status = value;
        }

        public int GetStatus() { return status; }
        public int GetDestination() { return destination; }
        public int GetPosition() { return position; }
    }
}
