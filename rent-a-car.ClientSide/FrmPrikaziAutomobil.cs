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
    public partial class FrmPrikaziAutomobil : Form
    {
        public Car car { get; set; }
        public FrmPrikaziAutomobil()
        {
            InitializeComponent();
        }
        public FrmPrikaziAutomobil(Car carForDisplaying)
        {
            if(carForDisplaying == null)
            {
                MessageBox.Show("Nemoguce prikazati automobil");
                this.Close();
            }
            car = carForDisplaying;
        
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

        public void FrmPretragaAutomobila_Load(object sender, EventArgs e)
        {
            UIController.Instance.LoadCar(car.CarID,lblMarka,lblModel);
            lblSediste.Text = "5";
            lblGSP.Text = "poseduje";
            lblGodina.Text = "2015";
        }
        
        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }
}
