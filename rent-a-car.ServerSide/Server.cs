using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rent_a_car.ServerSide
{
    public class Server
    {
        Socket serverSocket;
        List<ClientHandler> clients = new List<ClientHandler>();

        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Connect()
        {
            try
            {
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                serverSocket.Listen(5);
                Thread thread = new Thread(ListenNetwork);
                thread.IsBackground = true;
                thread.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void ListenNetwork()
        {
            bool end = false;
            while (!end)
            {
                try
                {
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler clientHandler = new ClientHandler(clientSocket, clients);
                    Thread thread = new Thread(clientHandler.HandleThread);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch (Exception)
                {

                    end = true;
                }

            }
        }
    }
}
