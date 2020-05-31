using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Server.System_operations
{
    internal class LogOutUser : GeneralSystemOperation
    {
        internal override object Execute(Domain.DomainObject domainObject)
        {
            return true;
        }
    }
}
