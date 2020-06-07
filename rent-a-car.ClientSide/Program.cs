using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SignIn signInFrm = new SignIn();
            signInFrm.ShowDialog();
        }
    }
}
