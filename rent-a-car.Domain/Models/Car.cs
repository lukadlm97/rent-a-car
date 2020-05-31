using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace rent_a_car.Domain.Models
{
    public class Car:GeneralSystemOperation
    {
        [Browsable(false)]
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        [Browsable(false)]
        public string CONDITIONS;

        [Browsable(false)]
        public string ID
        {
            get
            {
                return "CarID";
            }
        }

        [Browsable(false)]
        public string TableName
        {
            get
            {
                return "Car";
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return $" (CarID,Brand,Model) VALUES({CarID},'{Brand}','{Model}')";
            }
        }

        [Browsable(false)]
        public string Update => throw new NotImplementedException();

        [Browsable(false)]
        public string ConditionID
        {
            get
            {
                return $" CarID={CarID}";
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
            Car car = new Car()
            {
                CarID = (int)row["CarID"],
                Brand = (string)row["Brand"],
                Model = (string)row["Model"]
            };

            return car;
        }

        [Browsable(false)]
        public GeneralSystemOperation ReadRowOfTableID(DataRow row)
        {
            Car car = new Car()
            {
                CarID = (int)row["CarID"]
            };
            return car;
        }
    }
}
