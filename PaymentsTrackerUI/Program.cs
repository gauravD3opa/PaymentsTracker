﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsTrackerUI
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
        }
    }
}
