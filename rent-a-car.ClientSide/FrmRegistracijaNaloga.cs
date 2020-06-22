using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmRegistracijaNaloga : Form
    {
        public FrmRegistracijaNaloga()
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
        private void KreirajKorisnika_Click(object sender,EventArgs e)
        {
            if (UIController.Instance.SignUp(txtIme, txtKorIme, txtLozinka, txtLozinka2, txtTelefon))
            {
                MessageBox.Show("Uspesno ste kreirali nalog.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspeno kreiranje naloga!");
            }
        }
    }
}
