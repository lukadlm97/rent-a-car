using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    class FindCars : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Car car = (Car)domainObject;

            List<Car> cars = Broker.Instance.GetForCondition(car).OfType<Car>().ToList();

            return cars;
        }
    }
}
