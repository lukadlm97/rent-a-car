using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class DeleteUser : GeneralSystemOperation
    {
        internal override object Execute(DomainObject domainObject)
        {
            Broker.Instance.DeleteOne(domainObject);

            return true;    
        }
    }
}
