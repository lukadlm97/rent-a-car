using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace rent_a_car.Domain
{
    public interface DomainObject
    {
        DomainObject ReadRowOfTable(DataRow row);
        DomainObject ReadRowOfTableID(DataRow row);

        string ID { get; }
        string TableName { get; }
        string Insert { get; }
        string Update { get; }
        string ConditionID { get; }
        string MainCondition { get; }


    }
}
