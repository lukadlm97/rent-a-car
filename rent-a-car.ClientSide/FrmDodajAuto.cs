using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmDodajAuto : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancel_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public FrmDodajAuto()
        {
            InitializeComponent();
        }
        private void DodajAuto_Click(object sender, EventArgs e)
        {
            if (UIController.Instance.CreateCar(txtMarka,txtModel))
            {
                MessageBox.Show("Uspesno ste kreirali automobil.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno kreiranje automobila.");
            }
        }
    }
}
