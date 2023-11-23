using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Date not valid")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "this field is required!")]
        [Key,MaxLength(7,ErrorMessage ="Must be 7 caracteres "),MinLength(7, ErrorMessage = "Must be 7 caracteres ")]
        public string PassportNumber{ get; set; }
        [EmailAddress(ErrorMessage = "Address not valid")]
        public string EmailAddress { get; set; }  //EmailAddressAttribute  
        
        //[MinLength(3, ErrorMessage = "length min=3 "),MaxLength(25, ErrorMessage = "length max=25! ")]
        //public string FirstName { get; set; }

        //public string LastName { get; set; }
        public FullName Name { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "number not valid")]
        public string TelNumber { get; set; }
        //public  IList<Flight> Flights { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        // public int PassengerId { get; set; }
        public int Age {
            get 
            {
                if (BirthDate != null)
                {
                    if (DateTime.Now.Month - BirthDate.Month > 0 ||
                    (DateTime.Now.Month - BirthDate.Month == 0 && DateTime.Now.Day - BirthDate.Day >= 0))
                        return DateTime.Now.Year - BirthDate.Year;
                    else
                        return DateTime.Now.Year - BirthDate.Year - 1;
                }
                return 0;
            }
            }
        public override string ToString()
        {
            return "{BirthDate: " + BirthDate + "|" + "PassportNumber: " + PassportNumber + "|" + "EmailAddress: " + EmailAddress + "| FirstName: " + Name.FirstName + "LastName: " + Name.LastName + "|" + "TelNumber: " + TelNumber + "}";
        }
        //public bool CheckProfile(string FirstName,string LastName)
        //{
        //    return (FirstName == this.FirstName&&LastName==this.LastName);
        //}
        //public bool CheckProfile(string FirstName, string LastName, string EmailAddress)
        //{
        //    return (FirstName == this.FirstName && LastName == this.LastName && this.EmailAddress == EmailAddress);
        //}
        public bool CheckProfile(string FirstName, string LastName, string EmailAddress = null)
        {
            return (FirstName == this.Name.FirstName && LastName == this.Name.LastName && (EmailAddress == null || this.EmailAddress == EmailAddress));
        }
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
        /* public void GetAge(DateTime birthDate, ref int calculatedAge) // indication on peut utiliser DateTime.Now.DayOfYear 
        {
            if (DateTime.Now.Month - birthDate.Month > 0 ||
                (DateTime.Now.Month - birthDate.Month == 0 && DateTime.Now.Day - birthDate.Day >= 0))
                calculatedAge = DateTime.Now.Year - birthDate.Year;
            else
                calculatedAge = DateTime.Now.Year - birthDate.Year - 1;
        }*/
        /*public void GetAge(Passenger aPassenger)
        {
            
            if (DateTime.Now.Month - aPassenger.BirthDate.Month > 0 ||
                (DateTime.Now.Month - aPassenger.BirthDate.Month == 0 && DateTime.Now.Day - aPassenger.BirthDate.Day >= 0))
                aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
            else
                aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year - 1;
            
        }*/




    }
}
