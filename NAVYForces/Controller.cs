﻿using System;
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
        void DrawMap(Bitmap screen, Graphics graf);
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
            map.AddConnection(5, 8);
            passengers.Add(new Passenger(45, 215));
            taxies.Add(new Taxi(4));
            //map.AddConnection(8, 115);
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

        public void Next()
        {
            for (int i = 0; i < taxies.Count; i++) taxies[i].Next();
        }
        public void DrawMap(Bitmap screen, Graphics graf)
        {
            int m = map.M;
            int n = map.N;
            float width, height;
            
            if (m <= n)
            {
                width = Form1.ActiveForm.Size.Width / (3 * n);                
                height = width;
            }
            else
            {
                width = Form1.ActiveForm.Size.Width / (3 * m);
                height = width;
            }
                
            Pen pene = new Pen(Color.Black, 1);
            Pen penp = new Pen(Color.Green, 1);
            Pen pent = new Pen(Color.Red, 1);


            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    graf.DrawEllipse(pene, 10 + i * Form1.pic.Width / (n+2), 10 + j * Form1.pic.Height / (m+2), width, height);
                    
                    for (int k = 0; k < GetPassengerCount(); k++)
                    {

                        if (passengers[k].Position == j * m + i)
                            graf.DrawRectangle(penp, 10 + width/3+ i * Form1.pic.Width / (n + 2), 
                                                     10+width/3 + j * Form1.pic.Height / (m + 2), width / 3, height / 3);
                    }
                    for (int t = 0; t < GetTaxiCount(); t++)
                    {

                        if ( taxies[t].Position == j * m + i)
                            graf.DrawRectangle(pent, 10 + width / 4 + i * Form1.pic.Width / (n + 2),
                                                     10 + width / 4 + j * Form1.pic.Height / (m + 2), width / 2, height / 2);
                    }
                    for (int c = 0; c < map.Connections[j*m+i].Count; c++)
                    {
                        int tmpX,tmpY;
                        PointOneToTwo(map.Connections[j * m + i][c], out tmpX, out tmpY);
                        graf.DrawLine(pene, 10 + width / 2 + i * Form1.pic.Width / (n + 2), 10 + width / 2 + j * Form1.pic.Height / (m + 2),
                                            10 + width / 2 + tmpX * Form1.pic.Width / (n + 2), 10 + width / 2 + tmpY * Form1.pic.Height / (m + 2));
                    }
                }         
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

        public List<int> GetPassengersIdsInPoint(int id)
        {
            List<int> output = new List<int>(0);
            for (int i = 0; i < passengers.Count; i++) if (passengers[i].Position == id) output.Add(i);
            return output;
        }

        public List<int> GetWayToClosestPass(int point)
        {
            List<int> output = new List<int>(0);
            var tmp = new List<int>(0);

            for (int i = 0; i < passengers.Count; i++) 
                if (passengers[i].Status==PassengerStatus.OnStreet&&
                    map.CalculateWay(point, passengers[i].Position, out tmp) && 
                    (tmp.Count < output.Count || output.Count==0)) output = tmp;

            return output;
        }

        public bool CalculateWay(int from, int to, out List<int> way)
        {
            return map.CalculateWay(from, to, out way);
        }
    }
}
