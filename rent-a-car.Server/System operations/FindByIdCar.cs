using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    class FindByIdCar : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Car car = (Car)domainObject;
                
            Car newCar = (Car)Broker.Instance.GetOneForID(car);

            return newCar;
        }
    }
}
