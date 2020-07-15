using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmOtkazivanjeRezervacije : Form
    {
        public FrmOtkazivanjeRezervacije()
        {
            InitializeComponent();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_LoadReservation(object sender, EventArgs e)
        {
            if (!UIController.Instance.LoadListOfReservation(dgvRezervacije))
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void CloseReservation_Click(object sender, EventArgs e)
        {
            if (UIController.Instance.CloseReservation(dgvRezervacije))
            {
                MessageBox.Show("Uspesno izbrisana rezervacija");
                FrmPretragaAutomobila_Load(null,null);
                return;
            }

            MessageBox.Show("Nije moguce izbrisati rezerevaciju!");
            return;
        }

        private void FrmPretragaAutomobila_Load(object sender, EventArgs e)
        {
            UIController.Instance.LoadListOfReservation(dgvRezervacije);
            // KontrolerKI.Instance.UcitajListuStalnihPolazaka(dgvStalniPolasci);
        }

    }
}
