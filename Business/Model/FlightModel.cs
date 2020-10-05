using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class FlightModel:Model
    {
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int? Delay { get; set; }
        public Customer Customer { get; set; }
    }
}
