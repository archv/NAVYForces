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
        Controller Controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawMapButton_Click(object sender, EventArgs e)
        {
            Controller.DrawMap();
        }

        private void ShowPanelButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            
        }
    }
}
