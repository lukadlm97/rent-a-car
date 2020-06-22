using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace rent_a_car.ClientSide
{
    internal class UIController
    {

        private static UIController instance;

        private UIController()
        {

        }

        public static UIController Instance
        {
            get
            {
                if (instance == null)
                    instance = new UIController();
                return instance;
            }
        }

        public bool ConnectToServer()
        {
            if (NetworkCommunication.Instance.ConnectToServer())
            {
                return true;
            }
            return false;
        }

        internal bool SignIn(TextBox txtKorIme, TextBox txtLozinka)
        {
            Sesion.Instance.User.UserType.TypeName = "user";
            return true;
            if(string.IsNullOrEmpty(txtKorIme.Text) || string.IsNullOrEmpty(txtLozinka.Text))
            {
                MessageBox.Show("Sva polja su obavezna!");
                return false;
            }

            User logInUser = new User
            {
                Name = txtKorIme.Text,
                Password = txtLozinka.Text
            };

            User user = (User)NetworkCommunication.Instance.SignIn(logInUser);

            if(user == null)
            {
                txtKorIme.Text = null;
                txtLozinka.Text = null;
                return false;
            }

            Sesion.Instance.User = user;

            return true;

        }
    }
}
