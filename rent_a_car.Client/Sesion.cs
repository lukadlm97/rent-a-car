using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace rent_a_car.Client
{
    public class Sesion
    {
        private static Sesion instance;
        public int UserID { get; set; }
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
