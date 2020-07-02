using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace rent_a_car.ClientSide
{
    internal class NetworkCommunication
    {
        private static NetworkCommunication instance;
        Socket clientSocket;
        NetworkStream clientStream;
        BinaryFormatter binaryFormater;


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
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                clientStream = new NetworkStream(clientSocket);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal List<Car> GetCarsByConditions(Car car)
        {
            DataTransferObject transferObject = new DataTransferObject
            {
                Operation = Operation.FindCar,
                Object = car
            };

            binaryFormater.Serialize(clientStream, transferObject);
            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return (List<Car>)transferObject.Result;
        }

        internal List<Car> LoadCars()
        {
            DataTransferObject transferObject = new DataTransferObject
            {
                Operation = Operation.GetAllCars,
                Object = new Car()
            };

            binaryFormater.Serialize(clientStream, transferObject);
            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return (List<Car>)transferObject.Result;
        }

        internal List<Reservation> GetReservationsByConditions(Reservation reservation)
        {
            DataTransferObject transferObject = new DataTransferObject
            {
                Operation = Operation.FindReservation,
                Object = reservation
            };

            binaryFormater.Serialize(clientStream, transferObject);
            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return (List<Reservation>)transferObject.Result;
        }

        internal List<Reservation> LoadReservation()
        {
            DataTransferObject transferObject = new DataTransferObject
            {
                Operation = Operation.GetAllReservations,
                Object = new Car()
            };

            binaryFormater.Serialize(clientStream, transferObject);
            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return (List<Reservation>)transferObject.Result;
        }

        internal object CreateCar(Car carForCreate)
        {
            binaryFormater = new BinaryFormatter();
            DataTransferObject transferObject = new DataTransferObject();

            transferObject.Operation = Operation.CreateCar;
            transferObject.Object = carForCreate;

            binaryFormater.Serialize(clientStream, transferObject);

            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return transferObject.Result;
        }

        internal object SignIn(User logInUser)
        {
            binaryFormater = new BinaryFormatter();
            DataTransferObject transferObject = new DataTransferObject();

            transferObject.Operation = Operation.SignIn;
            transferObject.Object = logInUser;

            binaryFormater.Serialize(clientStream, transferObject);

            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return transferObject.Result;

        }

        internal object SignUp(User userForSignUp)
        {
            binaryFormater = new BinaryFormatter();
            DataTransferObject transferObject = new DataTransferObject();

            transferObject.Operation = Operation.SignUp;
            transferObject.Object = userForSignUp;

            binaryFormater.Serialize(clientStream, transferObject);

            transferObject = (DataTransferObject)binaryFormater.Deserialize(clientStream);
            return transferObject.Result;

        }
    }
}
