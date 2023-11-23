﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing=0,
        AirBus=1
    }
    public class Plane
    {
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }  
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public virtual IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "{Capacity: "+Capacity+"|"+ "ManufactureDate: "+ManufactureDate +"|"+"PlaneId: "+PlaneId+"| Plane Type: "+MyPlaneType + "}"; 
        }
        public Plane(PlaneType pt, int capacity,DateTime date)
        {
            this.Capacity = capacity;
            this.MyPlaneType = pt;
            this.ManufactureDate=date;
        }
        public Plane()
        {
        }
    }
}
