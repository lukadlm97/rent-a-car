using rent_a_car.Domain;
using rent_a_car.Server.System_operations;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace rent_a_car.Server
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
                    DataTransferObject transferClass = 
                        (DataTransferObject)binaryFormatter.Deserialize(clientStream);

                    switch (transferClass.Operation)
                    {
                        case Operation.SignIn:
                            SignInUser signInUser
                                = new SignInUser();
                            transferClass.Result = signInUser.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.SignUp:
                            RegisterUser registerUser = new RegisterUser();
                            transferClass.Result = registerUser.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.LogOut:
                            end = true;
                            break;
                        case Operation.CreateCar:
                            CreateCar createCar = new CreateCar();
                            transferClass.Result = createCar.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.CreateReservation:
                            CreateReservation createReservation = new CreateReservation();
                            transferClass.Result = createReservation.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.DeleteCar:
                            DeleteUser deleteUser = new DeleteUser();
                            transferClass.Result = deleteUser.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.DeleteReservation:
                            DeleteReservation deleteReservation = new DeleteReservation();
                            transferClass.Result = deleteReservation.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.FindCar:
                            FindCar findCar = new FindCar();
                            transferClass.Result = findCar.ExecuteSystemOperation(transferClass.Object);
                            break;
                        case Operation.FindReservation:
                            FindReservation findReservation = new FindReservation();
                            transferClass.Result = findReservation.ExecuteSystemOperation(transferClass.Object);
                            break;
                    }
                }
                catch (Exception)
                {
                    end = true;
                }
            }
        }

    }
}
