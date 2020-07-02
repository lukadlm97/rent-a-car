using rent_a_car.DatabaseBroker;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class GetAllCars : GeneralSystemOperation
    {
        internal override object Execute(Domain.DomainObject domainObject)
        {
            Car car = (Car)domainObject;

            List<Car> cars = Broker.Instance.GetAll(car).OfType<Car>().ToList();

            return cars;
        }
    }
}
