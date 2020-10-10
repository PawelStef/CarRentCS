using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {
        public string PlateId { get; set; }

        public Segment Segment { get; set; }

        public double Price { get; set; }

        public List<Reservation> ReservationHistory { get; set; }


    }
}
