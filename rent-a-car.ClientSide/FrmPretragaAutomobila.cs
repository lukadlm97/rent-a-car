using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    public partial class FrmPretragaAutomobila : Form
    {
        public FrmPretragaAutomobila()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            if (!UIController.Instance.LoadListOfCars(dgvAutomobili))
            {
                this.Close();
            }
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
        private void btnPretragaAutomobila_Click(object sender, EventArgs e)
        {
            UIController.Instance.SearchCars(txtMarka,txtModel,dgvAutomobili);
            // KontrolerKI.Instance.UcitajListuStalnihPolazaka(dgvStalniPolasci);
        }
        private void FrmPretragaAutomobila_Load(object sender, EventArgs e)
        {
            UIController.Instance.LoadListOfCars(dgvAutomobili);
            // KontrolerKI.Instance.UcitajListuStalnihPolazaka(dgvStalniPolasci);
        }
        
        private void btnPrikaziAuto_Click(object sender, EventArgs e)
        {
            Car car = UIController.Instance.GetCarFromDgv(dgvAutomobili);

            if(car == null)
            {
                MessageBox.Show("Morate selektovati red u tabeli!");
                return;
            }

            FrmPrikaziAutomobil frmPrikaziAutomobil = new FrmPrikaziAutomobil(car);
            frmPrikaziAutomobil.ShowDialog();
        }
    }
}
