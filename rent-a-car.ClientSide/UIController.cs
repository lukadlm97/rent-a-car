using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        internal void SearchCars(TextBox txtMarka, TextBox txtModel, DataGridView dgvAutomobili)
        {
            string criteriaBrend = txtMarka.Text;
            string criteriaModel = txtModel.Text;

            Car car = new Car();

            car.CONDITIONS = $"Brend LIKE '%{criteriaBrend}%' OR Model LIKE '%{criteriaModel}%'";

            List<Car> cars = (List<Car>)NetworkCommunication.Instance.GetCarsByConditions(car);

            if(cars == null)
            {
                MessageBox.Show("Nema automobila za kriterijum!");
                return;
            }
            MessageBox.Show("Sistem je pronasao sledece automobile za kriterijum");
            dgvAutomobili.DataSource = new BindingList<Car>(cars);
        }

        internal void LoadListOfReservation(DataGridView dgvReservation)
        {
            List<Reservation> reservations = (List<Reservation>)NetworkCommunication.Instance.LoadReservation();

            if (reservations == null)
            {
                MessageBox.Show("Sistem ne moze da ucita rezervacije!");
                dgvReservation.DataSource = new BindingList<Reservation>();
                return;
            }
            MessageBox.Show("System has loaded cars!");
            dgvReservation.DataSource = new BindingList<Reservation>(reservations);
        }


        internal void LoadListOfCars(DataGridView dgvAutomobili)
        {
            List<Car> cars = (List<Car>)NetworkCommunication.Instance.LoadCars();

            if(cars == null)
            {
                MessageBox.Show("Ucitani su automobili!");
                dgvAutomobili.DataSource = new BindingList<Car>();
                return;
            }
            MessageBox.Show("System has loaded cars!");
            dgvAutomobili.DataSource = new BindingList<Car>(cars);
        }

        internal bool CreateCar(TextBox txtMarka, TextBox txtModel)
        {
            if (string.IsNullOrEmpty(txtMarka.Text.ToString()) ||
                string.IsNullOrEmpty(txtModel.Text.ToString()))
            {
                return false;
            }

            Car carForCreate = new Car
            {
                Model = txtModel.Text.ToString(),
                Brand = txtMarka.Text.ToString()
            };

            Car car = (Car)NetworkCommunication.Instance.CreateCar(carForCreate);

            if (car == null)
                return false;

            return true;
        }

        internal bool SignUp(TextBox txtIme, TextBox txtKorIme, TextBox txtLozinka, TextBox txtLozinka2, TextBox txtTelefon)
        {
            if (string.IsNullOrEmpty(txtIme.Text.ToString()) ||
                string.IsNullOrEmpty(txtKorIme.Text.ToString()) ||
                string.IsNullOrEmpty(txtLozinka.Text.ToString()) ||
                string.IsNullOrEmpty(txtLozinka2.Text.ToString()) ||
                string.IsNullOrEmpty(txtTelefon.Text.ToString()))
            {
                return false;
            }
            if(txtLozinka.ToString() != txtLozinka2.ToString())
            {
                return false;
            }

            User userForSignUp = new User
            {
                Name = txtKorIme.Text.ToString(),
                Phone = txtTelefon.Text.ToString(),
                Password = txtLozinka.Text.ToString()
            };

            User user = (User)NetworkCommunication.Instance.SignUp(userForSignUp);
            
            if(user == null)
            {
                txtIme = null;
                txtKorIme = null;
                txtLozinka = null;
                txtLozinka2 = null;
                txtTelefon = null;
                return false;
            }

            return true;
        }

        internal bool SignIn(TextBox txtKorIme, TextBox txtLozinka)
        {
            Sesion.Instance.User.UserType.TypeName = "admin";
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
