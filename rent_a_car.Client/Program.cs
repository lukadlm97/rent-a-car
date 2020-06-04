using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FrmLogIn frmLogIn = new FrmLogIn();
            frmLogIn.ShowDialog();
        }
    }
}
