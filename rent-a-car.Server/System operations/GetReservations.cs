using rent_a_car.DatabaseBroker;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class GetReservations : GeneralSystemOperation
    {
        internal override object Execute(Domain.DomainObject domainObject)
        {
            Reservation reservation = (Reservation)domainObject;

            reservation.CONDITIONS = $"ReservationID={reservation.ReservationID}";


            return Broker.Instance.GetOneForID(reservation);
        }
    }
}
