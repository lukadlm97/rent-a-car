using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
