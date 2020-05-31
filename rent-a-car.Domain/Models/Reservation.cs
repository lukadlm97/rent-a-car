using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace rent_a_car.Domain.Models
{
    public class Reservation:GeneralSystemOperation
    {
        [Browsable(false)]
        public int ReservationID { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateOfReservation { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }


        [Browsable(false)]
        public string CONDITIONS;


        [Browsable(false)]
        public string ID
        {
            get
            {
                return "ReservationID";
            }
        }

        [Browsable(false)]
        public string TableName
        {
            get
            {
                return "Reservation";
            }
        }

        [Browsable(false)]
        public string Insert
        {
            get
            {
                return $" (ReservationID,UserID,CarID,DateFrom,DateTo,DateOfReservation,LocationFrom,LocationTo) VALUES({ReservationID},{User.UserID},{Car.CarID},'{DateFrom}','{DateTo}','{DateOfReservation}','{LocationFrom}','{LocationTo}')";
            }
        }

        [Browsable(false)]
        public string Update
        {
            get
            {
                return $" ReservationID={ReservationID}";
            }
        }

        [Browsable(false)]
        public string ConditionID
        {
            get
            {
                return $" ReservationID={ReservationID}";
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
            Reservation reservation = new Reservation()
            {
                ReservationID = (int)row["ReservationID"],
                User = new User
                {
                    UserID = (int)row["UserID"]
                },
                Car = new Car
                {
                    CarID = (int)row["CarID"]
                },
                LocationTo = (string)row["LocationTo"],
                LocationFrom = (string)row["LocationFrom"],
                DateFrom = (DateTime)row["DateFrom"],
                DateTo = (DateTime)row["DateTo"],
                DateOfReservation = (DateTime)row["DateOfReservation"],
            };
            return reservation;
        }

        [Browsable(false)]
        public GeneralSystemOperation ReadRowOfTableID(DataRow row)
        {
            Reservation reservation = new Reservation()
            {
                ReservationID = (int)row["ReservationID"]
            };
            return reservation;
        }
    }
}
