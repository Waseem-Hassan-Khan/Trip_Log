using DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Trip_Log.Models
{
    public class TripLogModel
    {
           [Key]
            public int TripId { get; set; }
            public int DestinationId { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int AccommodationId { get; set; }
            public int ThingToDo1 { get; set; }
            public int ThingToDo2 { get; set; }
            public int ThingToDo3 { get; set; }

        public virtual Destination DestinationEntity { get; set; }
        public virtual Accommodation AccommodationEntity { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
    }
    }