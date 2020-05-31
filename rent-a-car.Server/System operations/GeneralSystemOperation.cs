using rent_a_car.DatabaseBroker;
using rent_a_car.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal abstract class GeneralSystemOperation
    {
        internal Object ExecuteSystemOperation(Domain.DomainObject domainObject)
        {
            object result = null;
            try
            {
                Broker.Instance.OpenConnection();
                Broker.Instance.StartTransaction();

                result = Execute(domainObject);
                Broker.Instance.CommitTransaction();
            }catch(Exception e)
            {
                Broker.Instance.RollbackTransaction();
                result = false;
            }
            finally
            {
                Broker.Instance.CloseConnection();
            }

            return result;
        }

        internal abstract object Execute(Domain.DomainObject domainObject);
    }
}
