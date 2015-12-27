using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public AppStatus Status 
        {
            set 
            {
                switch (value)
                {
                    case AppStatus.Idle: 
                        enableBtns();
                        tmpstatus = -1;
                        break;
                    case AppStatus.AddingConnection: 
                        AddPassBtn.Enabled = false;
                        AddTaxiBtn.Enabled = false;
                        AddConnBtn.Text = "Отменить";
                        TopLabel.Text = "Выберите точку, в которой начинается связь.";
                        break;
                    case AppStatus.AddingPassenger:
                        AddPassBtn.Text = "Отменить";
                        AddTaxiBtn.Enabled = false;
                        AddConnBtn.Enabled = false;
                        TopLabel.Text = "Выберите точку, в которой будет находиться пассажир.";
                        break;
                    case AppStatus.AddingTaxi:
                        AddPassBtn.Enabled = false;
                        AddTaxiBtn.Text = "Отменить";
                        AddConnBtn.Enabled = false;
                        TopLabel.Text = "Выберите точку, в которой будет стоять такси.";
                        break;
                }

                status = value; 
                Refresh();
            } 
            get { return status; } 
        }

        private void enableBtns()
        {
            AddConnBtn.Enabled = true;
            AddPassBtn.Enabled = true;
            AddTaxiBtn.Enabled = true;

            AddConnBtn.Text = "Добавить участок пути";
            AddTaxiBtn.Text = "Добавить такси";
            AddPassBtn.Text = "Добавить пассажира";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawMapButton_Click(object sender, EventArgs e)
        {
            listBoxTaxi.Items.Clear();       
            listBoxPassngrs.Items.Clear();
            Program.FController.ClearAll();
            TopLabel.Text = startTopLabelText;
            SelectedPtLabel.Text = "Точка не выбрана";
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            screen = new Bitmap(2000,2000);
            pictureBox1.Image = screen;
            graph = Graphics.FromImage(screen);
            pic = this.pictureBox1;
        }

        private void Nexybutt_Click(object sender, EventArgs e)
        {
            Program.FController.Next();
            Refresh();
        }

        private void mapRedraw(bool drawAll = false, int drawGray = -1)
        {
            Graphics.FromImage(screen).Clear(Color.White);
            Program.FController.DrawMap(screen, graph, drawAll, drawGray);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = calculateChosenPoint(e.X, e.Y);

            listBoxTaxi.Items.Clear();       // clear listboxes and add info about chosen point
            listBoxPassngrs.Items.Clear();

            if (index >= 0)
            {
                switch (status)
                {
                    case AppStatus.AddingTaxi:
                        Program.FController.AddTaxi(new Taxi(index));
                        Status = AppStatus.Idle;
                        TopLabel.Text = "Такси добавлено в точку " + index.ToString() + ".";
                        Refresh();
                        break;

                    case AppStatus.AddingPassenger:
                        if (tmpstatus == -1)
                        {
                            tmpstatus = index;
                            TopLabel.Text = "Укажите точку (пункт) назначения для пассажира.";
                        }
                        else
                        {
                            Program.FController.AddPassenger(new Passenger(tmpstatus, index));
                            TopLabel.Text = "Пассажир добавлен в точку " + tmpstatus.ToString() + ".";
                            Status = AppStatus.Idle;
                            tmpstatus = -1;
                            mapRedraw();
                        }
                        break;

                    case AppStatus.AddingConnection:
                        if (tmpstatus == -1)
                        {
                            tmpstatus = index;
                            TopLabel.Text = "Укажите вторую точку связи.";
                            Refresh();
                        }
                        else
                            if (tmpstatus == index) TopLabel.Text = "Невозможно добавить связь в ту же точку. Выберите другую точку. Нажмите кнопку \"Отменить\" для отмены.";
                            else
                                try
                                {
                                    Program.FController.AddConnection(tmpstatus, index);
                                    TopLabel.Text = "Связь добавлена между точками " + tmpstatus.ToString() + " и " + index.ToString() + ".";
                                    Status = AppStatus.Idle;
                                    tmpstatus = -1;
                                    mapRedraw();
                                }  
                                catch(Exception ex)
                                {
                                    TopLabel.Text = ex.Message + " Выберите другую точку. Нажмите кнопку \"Отменить\" для отмены.";
                                }
                        break;
                }

                updateListsInfo(index);
            }
            else SelectedPtLabel.Text = "Точка не выбрана.";    // in case no point chosen
        }

        private int calculateChosenPoint(int x, int y)
        {
            int m = Program.FController.M,
                n = Program.FController.N;
            float size = Form1.ActiveForm.Size.Width / (3 * ((m <= n) ? n : m));

            for (int i = 0; i < Program.FController.N; i++)     // detect chosen point
                for (int j = 0; j < Program.FController.M; j++)
                    if (x > 10 + i * Form1.pic.Width / n && y > 10 + j * Form1.pic.Height / m  &&
                        x < 10 + i * Form1.pic.Width / n + size && y < 10 + j * Form1.pic.Height / m + size)
                        return j * m + i;
            return -1;
        }

        private void updateListsInfo(int index)
        {
            string tmpstr = new string('c', 0);

            //listBoxTaxi.Items.Clear();                                  // clear listboxes and add info about chosen point
            //listBoxPassngrs.Items.Clear();
            // ^ Already cleared in MouseClick

            SelectedPtLabel.Text = "Выбрана точка " + index.ToString() + ". Объекты в точке:";

            for (int i = 0; i < Program.FController.GetTaxiCount(); i++)
                if (Program.FController.GetTaxi(i).Position == index)
                {
                    Taxi taxi = Program.FController.GetTaxi(i);

                    tmpstr = "№" + i.ToString();
                    if (taxi.Position != taxi.Destination)
                        if (taxi.Destination == -1)
                            tmpstr += ", стоит";
                        else
                            tmpstr += " -> " + Program.FController.GetTaxi(i).Destination.ToString();
                    //tmpstr += ", w " + Program.FController.GetTaxi(i).WayLength.ToString() + " p " +
                            //Program.FController.GetTaxi(i).PassengersCount.ToString();
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

                tmpstr = "№" + passengers[i].ToString() + ((passenger.Destination!=passenger.Position)?(" -> " +
                        passenger.Destination.ToString()):("")) + ", " +
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
                case PassengerStatus.OnStreet: return "ждет";
                default: return "ждет";
            }
        }

        private void AddTaxiBtn_Click(object sender, EventArgs e) { addTaxiClicked(); }
        private void AddConnBtn_Click(object sender, EventArgs e) { addConnClicked(); }
        private void AddPassBtn_Click(object sender, EventArgs e) { addPassClicked(); }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) { this.Close(); return true; }
            if (keyData == Keys.W) { Program.FController.Next(); Refresh(); return true; }
            if (keyData == Keys.A) { addTaxiClicked(); return true; }
            if (keyData == Keys.S) { addPassClicked(); return true; }
            if (keyData == Keys.D) { addConnClicked(); return true; }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private string startTopLabelText = "Для начала работы воспользуйтесь кнопками внизу окна или нажмите на любую"+
                                           " точку на карте для получения информации о находящихся в ней объектах.";

        private void addTaxiClicked()
        {
            if (Status == AppStatus.AddingTaxi) TopLabel.Text = startTopLabelText;
            Status = (Status == AppStatus.AddingTaxi) ? AppStatus.Idle : AppStatus.AddingTaxi;
        }

        private void addPassClicked()
        {
            if (Status == AppStatus.AddingPassenger) TopLabel.Text = startTopLabelText;
            Status = (Status == AppStatus.AddingPassenger) ? AppStatus.Idle : AppStatus.AddingPassenger;
        }

        private void addConnClicked()
        {
            if (Status == AppStatus.AddingConnection) TopLabel.Text = startTopLabelText;
            Status = (Status == AppStatus.AddingConnection) ? AppStatus.Idle : AppStatus.AddingConnection;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            mapRedraw(Status==AppStatus.AddingConnection, tmpstatus);
        }
    }
}
