using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using static AM.Core.Services.IFlightService;

namespace AM.Core.Services
{
    public class FlightService : IFlightService 
    {
        public IList<Flight> Flights { get; set; }
        public IList<DateTime> GetFlightDates(string destination)
        {
          // IList<DateTime> result = new List<DateTime>();  
          //foreach(Flight flight in Flights)
          //  {
          //      if (flight.Destination == destination)
          //      {
          //          result.Add(flight.FlightDate);  
          //      }
          //  }
          //  return result;
            //// 2 eme methode 
            //return  Flights.Where(f=>f.Destination==destination)
            //     .Select(f => f.FlightDate).ToList(); 
          // LINQ 
            return (from f in Flights
                    where f.Destination == destination
                    select f.FlightDate).ToList();
        }
      
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":                                                       
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                        {
                            Console.WriteLine(f);                           
                        }
                    }
                    break;
                case "Departure":
                    foreach (Flight f in Flights)
                    {
                        if (f.Departure == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in Flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(f);
                        }
                    }                  
                   break;
                case "FlightId":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightId == int.Parse(filterValue))
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight f in Flights)
                    {
                        if (f.EstimatedDuration == int.Parse(filterValue))
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }

        }        
        public void ShowFlightDetails(Plane avion)
        {
            var result = from f in Flights 
                         where f.MyPlane == avion 
                         select new { f.FlightDate, f.Destination };

            foreach (var i in result)
            {
                Console.WriteLine(i.FlightDate+" | "+i.Destination + " | ");
            }

        }
        public int GetWeeklyFlightNumber(DateTime startDate)
        {
            return (from fl in Flights
                    where (fl.FlightDate - startDate).TotalDays >= 0
                    && (fl.FlightDate - startDate).TotalDays < 7
                    select fl).Count();         
        }
        public double GetDurationAverage(string destination)
        { 
            return (from fl in Flights
                    where fl.Destination == destination
                    select fl.EstimatedDuration).Average();
        }
        public IList<Flight> SortFlights()
        {            
            return( from fl in Flights
                        orderby fl.EstimatedDuration descending
                        select fl).ToList();           
        }               
        public IList<Traveller> GetThreeOlderTravellers(Flight flight)
        {
            //return (from p in flight.Passengers.OfType<Traveller>()
            //        orderby p.BirthDate
            //        select p).Take(3).ToList();
            return new List<Traveller>();
        }
        public void ShowGroupedFlights()
        {
            var result = from fl in Flights
                        group fl by fl.Destination;
             foreach(var grp in result)
            {
                Console.WriteLine(grp.Key);
                foreach(var flight in grp)
                {
                    Console.WriteLine(flight);
                }               
            }
        }
        public Passenger GetSeniorPassenger(GetScore meth)
        {
            //return(from fl in Flights
            //       from p in fl.Passengers 
            //       orderby meth(p) descending
            //       select p).First();    
            return new Passenger();
        }
    }
}
