using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    class FindReservations : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Reservation res = (Reservation)domainObject;

            List<Reservation> cars = Broker.Instance.GetForCondition(res).OfType<Reservation>().ToList();

            return cars;
        }
    }
}
