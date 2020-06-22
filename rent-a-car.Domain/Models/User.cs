using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace rent_a_car.Domain.Models
{
    [Serializable]
    public class User : DomainObject
    {
        [Browsable(false)]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        [Browsable(false)]
        public string CONDITIONS;

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "UserID";
            }
        }

        [Browsable(false)]
        public string TableName
        {
            get
            {
                return "User";
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return $" (UserID,Name,Phone,Password,UserTypeID) VALUES({UserID},'{Name}','{Phone}','{Password}',{UserType.UserTypeID})";
            }
        }

        [Browsable(false)]
        public string Update => throw new NotImplementedException();
        
        [Browsable(false)]
        public string ConditionID
        {
            get
            {
                return $" UserID={UserID}";
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
        public DomainObject ReadRowOfTable(DataRow row)
        {
            User user = new User()
            {
                UserID = (int) row["UserID"],
                Name = (string)row["Name"],
                Phone = (string)row["Phone"],
                Password = (string)row["Password"],
                UserType = new UserType()
                {
                    UserTypeID = (int) row["UserTypeID"]
                }
            };
            return user;
        }

        [Browsable(false)]
        public DomainObject ReadRowOfTableID(DataRow row)
        {
            User user = new User
            {
                UserID = (int)row["UserID"]
            };
            return user;
        }
    }
}
