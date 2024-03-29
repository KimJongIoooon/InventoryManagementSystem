﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAplication
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            dashboardScreen.BringToFront();
        }

        private void BDashboard_Click(object sender, EventArgs e)
        {
            dashboardScreen.BringToFront();
            panel2.Height = bDashboard.Height;
            panel2.Top = bDashboard.Top;
        }

        private void BVoorraad_Click(object sender, EventArgs e)
        {
            voorraadScreen.BringToFront();
            panel2.Height = bVoorraad.Height;
            panel2.Top = bVoorraad.Top;
        }

        private void BProducten_Click(object sender, EventArgs e)
        {
            productenScreen.BringToFront();
            panel2.Height = bProducten.Height;
            panel2.Top = bProducten.Top;
        }

        private void BMedewerkers_Click(object sender, EventArgs e)
        {
            medewerkersScreen.BringToFront();
            panel2.Height = bMedewerkers.Height;
            panel2.Top = bMedewerkers.Top;
        }

        private void BBestellingen_Click(object sender, EventArgs e)
        {
            bestellingenScreen.BringToFront();
            panel2.Height = bBestellingen.Height;
            panel2.Top = bBestellingen.Top;
        }

        private void bVerkopen_Click(object sender, EventArgs e)
        {
            verkopenScreen.BringToFront();
            panel2.Height = bVerkopen.Height;
            panel2.Top = bVerkopen.Top;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }
    }
}
