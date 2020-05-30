using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car.ServerSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStopServer.Enabled = false;
            lblStatus.Text = "Server doesnt started";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            bool success = server.Connect();

            if (success)
            {
                lblStatus.Text = "Server has been started";
                btnStart.Enabled = false;
                btnStopServer.Enabled = false;
            }
            else
            {
                lblStatus.Text = "Cant start server";
            }
        }
    }
}
