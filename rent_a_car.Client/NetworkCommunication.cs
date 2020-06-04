using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace rent_a_car.Client
{
    internal class NetworkCommunication
    {
        private static NetworkCommunication instance;
        Socket clientSocket;
        NetworkStream clientStream;
        BinaryFormater binaryFormater;


        private NetworkCommunication()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static NetworkCommunication Instance
        {
            get
            {
                if (instance == null)
                    instance = new NetworkCommunication();
                return instance;
            }
        }

        internal bool ConnectToServer()
        {
            try
            {
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"),9999));
                clientStream = new NetworkStream(clientSocket);
                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}
