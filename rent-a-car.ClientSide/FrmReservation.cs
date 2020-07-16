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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
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
        private void Load_FrmReservation(object sender,EventArgs e)
        {
            UIController.Instance.LoadListOfCars(dgvAutomobili);
        }
        
        private void search_Click(object sender, EventArgs e)
        {
            UIController.Instance.SearchCars(txtMarka, txtModel, dgvAutomobili);
        }
       
        private void viewCar_click(object sender, EventArgs e)
        {
            Car car = UIController.Instance.GetCarFromDgv(dgvAutomobili);

            if (car == null)
            {
                MessageBox.Show("Morate selektovati red u tabeli!");
                return;
            }

            FrmPrikaziAutomobil frmPrikaziAutomobil = new FrmPrikaziAutomobil(car);
            frmPrikaziAutomobil.ShowDialog();
        }
    }
}
