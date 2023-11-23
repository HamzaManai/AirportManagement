using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
namespace AM.Core.Extensions
{

    public static class FlightExtension
    {
        public static double GetDelay(this Flight flight)
        {
            return flight.EffectiveArrival.Subtract(flight.FlightDate).TotalMinutes - flight.EstimatedDuration;
        }
    }
}