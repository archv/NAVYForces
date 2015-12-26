using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NAVYForces
{
    interface iController
    {
        void Next();
        void DrawMap(Bitmap screen, Graphics graf, bool drawAll = false, int drawGray = -1);
        void AddTaxi(Taxi taxi);
        void AddPassenger(Passenger passenger);
        int GetPassengerCount();
        void AddConnection(int from, int to, bool reverse = true);
        bool CalculateWay(int from, int to, out List<int> way);
        Taxi GetTaxi(int id);
        int GetTaxiCount();
        Passenger GetPassenger(int id);
        List<int> GetPassengersIdsInPoint(int id);
        List<int> GetWayToClosestPass(int point);
        int M { get; }
        int N { get; }
        void ClearAll();
    }

    public class Controller:iController
    {
        private List<Taxi> taxies;
        private List<Passenger> passengers;
        private Map map;
        
        public Controller()
        {
            map = new Map();
            taxies = new List<Taxi>(0);
            passengers = new List<Passenger>(0);

            // Map structure:

            map.AddConnection(4, 5);
            map.AddConnection(5, 25);
            map.AddConnection(25, 45);
            map.AddConnection(25, 46);
            map.AddConnection(46, 45);
            map.AddConnection(46, 47);
            map.AddConnection(46, 66);
            map.AddConnection(66, 86);
            map.AddConnection(86, 87);
            map.AddConnection(87, 88);
            map.AddConnection(88, 89);
            map.AddConnection(89, 90);
            map.AddConnection(90, 91);
            map.AddConnection(91, 92);
            map.AddConnection(92, 93);
            map.AddConnection(93, 113);
            map.AddConnection(113, 114);

            map.AddConnection(114, 134);
            map.AddConnection(134, 154);
            map.AddConnection(154, 174);
            map.AddConnection(174, 194);
            map.AddConnection(194, 195);
            map.AddConnection(195, 196);

            passengers.Add(new Passenger(45, 5));
            passengers.Add(new Passenger(114, 5));
            passengers.Add(new Passenger(196, 25));
            passengers.Add(new Passenger(25, 114));

            taxies.Add(new Taxi(4));
            taxies.Add(new Taxi(113));
        }

        public void Next()
        {
            for (int i = 0; i < taxies.Count; i++) taxies[i].Next();
        }
        public void DrawMap(Bitmap screen, Graphics graf, bool drawAll = false, int drawGray = -1)
        {
            int m = map.M;
            int n = map.N;
            float size = Form1.pic.Width / (2 * ((m <= n)?n:m));                
                
            Pen pene = new Pen(Color.Black, 1);      // connection pen
            Pen penp = new Pen(Color.Green, 2);      // passenger pen
            Pen pent = new Pen(Color.Red, 2);        // taxi pen
            Pen pengray = new Pen(Color.Gray, 1);
            Pen penlightgray = new Pen(Color.LightGray, 1);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    bool present = false;
                    
                    for (int t = 0; t < GetTaxiCount(); t++)
                        if (taxies[t].Position == j * m + i)
                        {
                            graf.DrawRectangle(pent, 10 + size / 4 + i * Form1.pic.Width / n,
                                                     10 + size / 4 + j * Form1.pic.Height / m, size / 2, size / 2);
                            present = true;
                        }

                    for (int k = 0; k < GetPassengerCount(); k++)
                        if (passengers[k].Position == j * m + i)
                        {
                            graf.DrawRectangle(new Pen(((passengers[k].Status==PassengerStatus.Arrived)?Color.Green:Color.Orange),2), 10 + size / 3 + i * Form1.pic.Width / n,
                                                     10 + size / 3 + j * Form1.pic.Height / m, size / 3, size / 3);
                            present = true;
                        }
                            
                    
                    for (int c = 0; c < map.Connections[j*m+i].Count; c++)
                    {
                        int tmpX,tmpY;
                        PointOneToTwo(map.Connections[j * m + i][c], out tmpX, out tmpY);
                        graf.DrawLine(pene, 10 + size / 2 + i * Form1.pic.Width / n, 10 + size / 2 + j * Form1.pic.Height / m,
                                            10 + size / 2 + tmpX * Form1.pic.Width / n, 10 + size / 2 + tmpY * Form1.pic.Height / m );
                        present = true;
                    }

                    if (present || drawAll)
                    {
                        bool makeBlack = (drawGray == j * m + i || (!drawAll && present));
                        graf.DrawEllipse((makeBlack) ? pene : ((present)?pengray:penlightgray), 10 + i * Form1.pic.Width / n, 10 + j * Form1.pic.Height / m, size, size);
                    }
                }         
        }

        public void ClearAll()
        {
            passengers = new List<Passenger>(0);
            taxies = new List<Taxi>(0);
            map.ClearAll();
        }

        public void AddConnection(int from, int to, bool reverse = true)
        {
            map.AddConnection(from, to, reverse);
        }

        private void PointOneToTwo(int index, out int x, out int y)
        {
            for (int i=0;i<map.N;i++)
                for (int j=0;j<map.M;j++)
                    if (j * map.M + i == index)
                    {
                        x = i; y = j;
                        return;
                    }
            x = -1; y = -1;
        }
        public Passenger GetPassenger(int id)
        { return passengers[id]; }
        public Taxi GetTaxi(int id)
        { return taxies[id]; }

        public void AddTaxi(Taxi taxi)
        {
            taxies.Add(taxi);
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        public int GetPassengerCount()
        {
            return passengers.Count;
        }

        public int GetTaxiCount()
        {
            return taxies.Count;
        }

        public int M { get { return map.M; } }
        public int N { get { return map.N; } }

        public List<int> GetPassengersIdsInPoint(int id)
        {
            List<int> output = new List<int>(0);
            for (int i = 0; i < passengers.Count; i++) if (passengers[i].Position == id) output.Add(i);
            return output;
        }

        public List<int> GetWayToClosestPass(int point)
        {
            var output = new List<int>(0);
            var tmp = new List<int>(0);
            int lastid = -1;

            for (int i = 0; i < passengers.Count; i++)
                if (passengers[i].Status == PassengerStatus.Idle &&
                    map.CalculateWay(point, passengers[i].Position, out tmp) &&
                    (tmp.Count < output.Count || output.Count == 0))
                {
                    output = tmp;
                    passengers[i].Status = PassengerStatus.OnStreet;
                    if (lastid != -1) passengers[lastid].Status = PassengerStatus.Idle;
                    lastid = i;
                }

            return output;
        }

        public bool CalculateWay(int from, int to, out List<int> way)
        {
            return map.CalculateWay(from, to, out way);
        }
    }
}
