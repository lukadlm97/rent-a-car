using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace rent_a_car.Domain.Models
{
    public class UserType:GeneralSystemOperation
    {
        [Browsable(true)]
        public int UserTypeID { get; set; }
        public string TypeName { get; set; }

        [Browsable(false)]
        public string CONDITIONS;

        public string ID 
        {
            get
            {
                return "UserTypeID";
            }
        }
        [Browsable(false)]
        public string TableName
        {
            get
            {
                return "UserType";
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return $" (UserTypeId,TypeName) VALUES({UserTypeID},'{TypeName}')";
            }
        }
        [Browsable(false)]
        public string Update => throw new NotImplementedException();
        [Browsable(false)]
        public string ConditionID 
        {
            get
            {
                return $" UserTypeID={UserTypeID}";
            }
        }
        [Browsable(false)]
        public string MainCondition 
        { 
            get
            {
                return CONDITIONS;
            } 
        }
        [Browsable(false)]
        public GeneralSystemOperation ReadRowOfTable(DataRow row)
        {
            UserType userType = new UserType()
            {
                UserTypeID = (int)row["UserTypeID"],
                TypeName = (string)row["TypeName"]
            };
            return userType;
        }
        [Browsable(false)]
        public GeneralSystemOperation ReadRowOfTableID(DataRow row)
        {
            UserType userType = new UserType()
            {
                UserTypeID = (int)row["UserTypeID"]
            };
            return userType;
        }
    }
}
