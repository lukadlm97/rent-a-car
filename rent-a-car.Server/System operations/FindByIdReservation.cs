using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    class FindByIdReservation : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Reservation reservation = (Reservation)domainObject;

            Reservation reservationNew = (Reservation)Broker.Instance.GetOneForID(reservation);

            return reservationNew;
        }
    }
}
