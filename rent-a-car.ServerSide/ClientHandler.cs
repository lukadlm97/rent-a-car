﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using rent_a_car.ServerSide;

namespace rent_a_car.ServerSide
{
    public class ClientHandler
    {
        Socket clientSocket;
        NetworkStream clientStream;
        BinaryFormatter binaryFormatter;
        List<ClientHandler> clientsThreads;

        public ClientHandler(Socket socket, List<ClientHandler> handlers)
        {
            clientSocket = socket;
            clientsThreads = handlers;
            clientStream = new NetworkStream(clientSocket);
        }

        public void HandleThread()
        {
            bool end = false;
            binaryFormatter = new BinaryFormatter();
            while (!end)
            {
                try
                {
                   


                }
                catch (Exception)
                {
                    end = true;
                }
            }
        }

    }
}
