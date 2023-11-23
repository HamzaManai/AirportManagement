using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public interface IFlightService
    {
        /// <summary>
        /// retourne la liste des dates de vols pour une destination donne
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        IList<DateTime> GetFlightDates(string destination);

        /// <summary>
        /// qui affiche les vols en fonction de type de filtre et sa valeur
        /// </summary>
        /// <param name="filterType"></param>
        /// <param name="filterValue"></param>
        void GetFlights(string filterType, string filterValue);

        /// <summary>
        /// affiche les dates et les destinations de vols 
        /// </summary>
        /// <param name="avion"></param>
        void ShowFlightDetails(Plane avion);

        /// <summary>
        /// retourne le nombre de vols programmés pour une semaine à partir d’une date donnée
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        int GetWeeklyFlightNumber(DateTime startDate);

        /// <summary>
        /// retourne la moyenne de durées estimées des vols d’une destination donnée
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        double GetDurationAverage(string destination);
        /// <summary>
        /// retourne les vols triés par ordre décroissant de leurs durées estimées.
        /// </summary>
        /// <returns></returns>
        IList<Flight> SortFlights();

        /// <summary>
        /// retourner les trois passagers les plus âgés pour un vol donne
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        IList<Traveller> GetThreeOlderTravellers(Flight flight);

        /// <summary>
        /// afficher les vols groupés par destination
        /// </summary>
        void ShowGroupedFlights();
        public delegate int GetScore(Passenger passenger);

        /// <summary>
        /// renvoie le passager sénior
        /// </summary>
        /// <param name="meth"></param>
        /// <returns></returns>
        Passenger GetSeniorPassenger(GetScore meth);

    }
}
