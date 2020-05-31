using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class RegisterUser : GeneralSystemOperation
    {
        internal override object Execute(Domain.GeneralSystemOperation domainObject)
        {
            User user = (User)domainObject;
            user.UserID = Broker.Instance.GetID(user);

            Broker.Instance.Insert(user);

            return user;
        }
    }
}
