using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class CreateCar : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Car newCar = (Car)domainObject;

            newCar.CarID = Broker.Instance.GetID(newCar);

            Broker.Instance.Insert(newCar);

            return newCar;
        }
    }
}
