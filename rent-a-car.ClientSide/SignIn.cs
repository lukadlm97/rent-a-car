﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            if (UIController.Instance.ConnectToServer())
            {
               
            }
            else
            {
                MessageBox.Show("Neuspesno povezivanje sa serverom!");
                this.Close();
                return;
            }
        }
    }
}
