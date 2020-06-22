using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmGlavnaAdmin : Form
    {
        public FrmGlavnaAdmin()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void DodajAuto_Click(object sender, EventArgs e)
        {
            FrmDodajAuto frmDodajAuto = new FrmDodajAuto();
            frmDodajAuto.ShowDialog();
        }
        private void OtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            FrmOtkazivanjeRezervacije frmOtkazivanjeRezervacije = new FrmOtkazivanjeRezervacije();
            frmOtkazivanjeRezervacije.ShowDialog();
        }
    }
}
