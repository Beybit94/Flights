using System;
using System.Collections.Generic;
using System.Text;

namespace Business.QueryModels
{
    public class FlightQueryModel:QueryModel
    {
        public long Id { get; set; }
        public DateTime DepartureTimeFrom { get; set; }
        public DateTime DepartureTimeTo { get; set; }
        public DateTime ArrivalDateTimeFrom { get; set; }
        public DateTime ArrivalDateTimeTo { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
    }
}
