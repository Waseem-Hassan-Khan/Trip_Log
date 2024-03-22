using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip_Log.Models;

namespace DataAccessLayer.Models
{
    public class Accommodation
    {
        [Key]
        public int AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public string AccommodationPhone { get; set; }
        public string AccommodationEmail { get; set; }
        
        public virtual ICollection<TripLogModel> Trips { get; set; }
    }
}
