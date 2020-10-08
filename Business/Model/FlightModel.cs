using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class FlightModel:Model
    {
        public DateTime DepartureTime { get; set; }
        public string DepartureTimeStr
        {
            get
            {
                return DepartureTime.ToString("dd.mm.yyyy HH:m");
            }
        }
        public DateTime ArrivalDateTime { get; set; }
        public string ArrivalTimeStr
        {
            get
            {
                return ArrivalDateTime.ToString("dd.mm.yyyy HH:m");
            }
        }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int? Delay { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
