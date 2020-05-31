using rent_a_car.DatabaseBroker;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class VIewCar : GeneralSystemOperation
    {
        internal override object Execute(Domain.DomainObject domainObject)
        {
            Car car = (Car)domainObject;

            car.CONDITIONS = $" CarID={car.CarID}";

            return Broker.Instance.GetID(car);
        }
    }
}
