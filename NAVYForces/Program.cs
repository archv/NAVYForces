﻿//TODO:
//1. Добавить exception в get/set классов
//
//* Добавить вызов такси в конструктор пассажира

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVYForces
{
    static class Program
    {
        public static Controller FController = new Controller();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
