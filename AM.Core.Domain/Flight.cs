using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }   
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration{ get; set; }
        // [ForeignKey("PlaneId")] 2eme methode
        public virtual Plane? MyPlane { get; set; }
        [ForeignKey("MyPlane")]
        public int? PlaneId { get; set; }
        //public IList<Passenger> Passengers { get; set; }
        public string Comment { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        public override string ToString()
        {
            return "{Destination: " + Destination + "|" + "Departure: " + Departure + "|" + "FlightDate: " + FlightDate + "| FlightId: " + FlightId+ "EffectiveArrival: " + EffectiveArrival + "|" + "EstimatedDuration: " + EstimatedDuration + "|" + "Plane: " + MyPlane + "}"; 
        }
    }
}
