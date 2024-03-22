using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModel
{
    public class vmTripLog
    {
        public int TripId { get; set; }
        public string DestinationName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AccommodationName { get; set; }
        public string ThingToDo1 { get; set; }
        public string ThingToDo2 { get; set; }
        public string ThingToDo3 { get; set; }
    }
}
