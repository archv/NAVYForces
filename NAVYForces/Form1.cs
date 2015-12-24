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
        Controller Controller = new Controller();
        Bitmap screen; 
        Graphics graph;
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawMapButton_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(screen).Clear(Color.White);
            Controller.DrawMap(screen, graph);
            pictureBox1.Refresh();
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
           // Controller.Next();   
        }
    }
}
