using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using rent_a_car.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class SignInUser : GeneralSystemOperation
    {
        internal override object Execute(Domain.DomainObject domainObject)
        {
            User user = (User)domainObject;
            List<User> users = Broker.Instance.GetAll(user).OfType<User>().ToList();

            foreach(User u in users)
            {
                if (u.Name == user.Name && u.Password == user.Password)
                    return user;
            }
            return null;
        }
    }
}
