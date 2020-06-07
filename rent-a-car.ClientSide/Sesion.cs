using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.ClientSide
{
    public class Sesion
    {
        private static Sesion instance;
        public User User { get; set; }
        public Sesion()
        {

        }
        public static Sesion Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sesion();
                return instance;
            }
        }
    }
}
