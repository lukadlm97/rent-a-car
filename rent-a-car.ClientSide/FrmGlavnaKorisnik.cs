using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmGlavnaKorisnik : Form
    {
        public FrmGlavnaKorisnik()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void pretraga_Click(object sender, EventArgs e)
        {
            FrmPretragaAutomobila frmPretraga = new FrmPretragaAutomobila();
            frmPretraga.ShowDialog();
        }
    }
}
