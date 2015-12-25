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
    public enum AppStatus { Idle, AddingConnection, AddingTaxi, AddingPassenger };

    public partial class Form1 : Form
    {
        public static PictureBox pic;
        //Controller Controller = new Controller();      // откуда здесь взялся контроллер, сука?
        private Bitmap screen;
        private Graphics graph;
        private AppStatus status = AppStatus.Idle;
        private int tmpstatus = -1;

        public AppStatus Status { set { if(value!=AppStatus.Idle)SelectedPtLabel.Text = "Выберите точку"; status = value; } get { return status; } }

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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = calculateChosenPoint(e.X, e.Y);

            if (index>=0)
                switch(status)
                {
                    case AppStatus.Idle: updateListsInfo(index); break;
                    case AppStatus.AddingTaxi: 
                        Program.FController.AddTaxi(new Taxi(index));
                        status = AppStatus.Idle; 
                        mapRedraw();
                        break;
                    case AppStatus.AddingPassenger:
                        if (tmpstatus == -1)
                        {
                            tmpstatus = index;
                            SelectedPtLabel.Text = "Укажите точку назначения";
                        }
                        else
                        {
                            Program.FController.AddPassenger(new Passenger(tmpstatus, index));
                            SelectedPtLabel.Text = "Пассажир добавлен!";
                            status = AppStatus.Idle;
                            tmpstatus = -1;
                            mapRedraw();
                        }
                        break;
                    case AppStatus.AddingConnection:
                        if (tmpstatus == -1)
                        {
                            tmpstatus = index;
                            SelectedPtLabel.Text = "Укажите точку назначения";
                        }
                        else
                        {
                            Program.FController.AddConnection(tmpstatus, index);
                            SelectedPtLabel.Text = "Связь добавлена!";
                            status = AppStatus.Idle;
                            tmpstatus = -1;
                            mapRedraw();
                        }
                        break;
                }
            else SelectedPtLabel.Text = "Точка не выбрана";             // in case no point chosen
        }

        private int calculateChosenPoint(int x, int y)
        {
            int m = Program.FController.M,
                n = Program.FController.N;
            float size = Form1.ActiveForm.Size.Width / (3 * ((m <= n) ? n : m));

            for (int i = 0; i < Program.FController.N; i++)     // detect chosen point
                for (int j = 0; j < Program.FController.M; j++)
                    if (x > 10 + i * Form1.pic.Width / (n + 2) && y > 10 + j * Form1.pic.Height / (m + 2) &&
                        x < 10 + i * Form1.pic.Width / (n + 2) + size && y < 10 + j * Form1.pic.Height / (m + 2) + size)
                        return j * m + i;
            return -1;
        }

        private void updateListsInfo(int index)
        {
            string tmpstr = new string('c', 0);

            listBoxTaxi.Items.Clear();                                  // clear listboxes and add info about chosen point
            listBoxPassngrs.Items.Clear();
            SelectedPtLabel.Text = "Выбрана точка " + index.ToString();

            for (int i = 0; i < Program.FController.GetTaxiCount(); i++)
                if (Program.FController.GetTaxi(i).Position == index)
                {
                    Taxi taxi = Program.FController.GetTaxi(i);

                    tmpstr = i.ToString();
                    if (taxi.Position != taxi.Destination)
                        if (taxi.Destination == -1)
                            tmpstr += ", стоит";
                        else
                            tmpstr += " -> " + Program.FController.GetTaxi(i).Destination.ToString();
                    //tmpstr += ", w " + Program.FController.GetTaxi(i).WayLength.ToString() + " p " + Program.FController.GetTaxi(i).PassengersCount.ToString();
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
                         passengerStatusToString(passenger.Status);

                listBoxPassngrs.Items.Add(tmpstr);
            }
            if (listBoxPassngrs.Items.Count == 0)
            {
                listBoxPassngrs.Items.Add("Пассажиры в");
                listBoxPassngrs.Items.Add("данной точке");
                listBoxPassngrs.Items.Add("отсутствуют!");
            }
        }

        private string passengerStatusToString(PassengerStatus status)
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

        private void AddTaxiBtn_Click(object sender, EventArgs e)
        {
            Status = AppStatus.AddingTaxi;
            //SelectedPtLabel.Text = "Выберите точку";
        }

        private void AddPassBtn_Click(object sender, EventArgs e)
        {
            Status = AppStatus.AddingPassenger;
            //SelectedPtLabel.Text = "Выберите точку";
        }

        private void AddConnBtn_Click(object sender, EventArgs e)
        {
            Status = AppStatus.AddingConnection;
            //SelectedPtLabel.Text = "Выберите точку";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.A) Status = AppStatus.AddingTaxi;
            if (e.KeyCode == Keys.S) Status = AppStatus.AddingPassenger;
            if (e.KeyCode == Keys.D) Status = AppStatus.AddingConnection;
        }
    }
}
