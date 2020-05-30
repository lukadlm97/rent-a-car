using System;
using System.Collections.Generic;
using System.Text;

namespace rent_a_car.Domain.Models
{
    public class Reservation
    {
        public User User { get; set; }
        public Car Car { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateOfReservation { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
    }
}
