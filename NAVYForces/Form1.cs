using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVYForces
{
    public partial class Form1 : Form
    {
        public static PictureBox pic;
        //Controller Controller = new Controller();      // откуда здесь взялся контроллер, сука?
        Bitmap screen; 
        Graphics graph;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawMapButton_Click(object sender, EventArgs e)
        {
            mapRedraw();
        }


        private void Form1_Load(object sender, EventArgs e)
        {   
            screen = new Bitmap(2000,2000);
            pictureBox1.Image = screen;
            graph = Graphics.FromImage(screen);
            pic = this.pictureBox1;
            mapRedraw();
        }

        private void Nexybutt_Click(object sender, EventArgs e)
        {
            Program.FController.Next();
            mapRedraw();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            mapRedraw();
        }

        private void mapRedraw()
        {
            Graphics.FromImage(screen).Clear(Color.White);
            Program.FController.DrawMap(screen, graph);
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FController.AddPassenger(new Passenger(87, 4));
            Program.FController.DrawMap(screen, graph);
            Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X,
                y = e.Y,
                m = Program.FController.M,
                n = Program.FController.N,
                index = -1;
            string tmpstr = new string('c',0);
            float size = Form1.ActiveForm.Size.Width / (3 * ((m <= n) ? n : m));

            for (int i = 0; i < Program.FController.N; i++)
                for (int j = 0; j < Program.FController.M; j++)
                    if (x > 10 + i * Form1.pic.Width / (n + 2) && y > 10 + j * Form1.pic.Height / (m + 2) &&
                        x < 10 + i * Form1.pic.Width / (n + 2) + size && y < 10 + j * Form1.pic.Height / (m + 2) + size)
                    {
                        index = j * m + i;
                        goto CycleExit;             // easy way to get out of 2 cycles
                    }

            CycleExit:

            if (index>=0)
            {
                listBoxTaxi.Items.Clear();
                listBoxPassngrs.Items.Clear();
                SelectedPtLabel.Text = "Выбрана точка " + index.ToString();

                for (int i = 0; i < Program.FController.GetTaxiCount(); i++)
                    if (Program.FController.GetTaxi(i).Position == index)
                    {
                        Taxi taxi = Program.FController.GetTaxi(i);

                        tmpstr = i.ToString();
                        if(taxi.Position!=taxi.Destination)
                            if(taxi.Destination==-1)
                                tmpstr += ", стоит";
                            else
                            tmpstr += " -> " + Program.FController.GetTaxi(i).Destination;

                        listBoxTaxi.Items.Add(tmpstr);
                    }
                if (listBoxTaxi.Items.Count == 0)
                {
                    listBoxTaxi.Items.Add("Такси в");
                    listBoxTaxi.Items.Add("данной точке");
                    listBoxTaxi.Items.Add("отсутствуют!");
                }

                List<int> passengers = Program.FController.GetPassengersIdsInPoint(index);
                for (int i = 0; i < passengers.Count; i++)
                    {
                        Passenger passenger = Program.FController.GetPassenger(passengers[i]);

                        tmpstr = passengers[i].ToString() + " -> " + 
                                 passenger.Destination.ToString() + ", " +
                                 PassengerStatusToString(passenger.Status);

                        listBoxPassngrs.Items.Add(tmpstr);
                    }
                if (listBoxPassngrs.Items.Count == 0)
                {
                    listBoxPassngrs.Items.Add("Пассажиры в");
                    listBoxPassngrs.Items.Add("данной точке");
                    listBoxPassngrs.Items.Add("отсутствуют!");
                }
            }
            else SelectedPtLabel.Text = "Точка не выбрана";
        }

        private string PassengerStatusToString(PassengerStatus status)
        {
            switch (status)
            {
                case PassengerStatus.Arrived: return "приехал";
                case PassengerStatus.Idle: return "ждет";
                case PassengerStatus.InCar: return "едет";
                case PassengerStatus.OnStreet: return "ждет на улице";
                default: return "ждет";
            }
        }
    }
}
