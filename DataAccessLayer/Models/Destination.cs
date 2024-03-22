using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip_Log.Models;

namespace DataAccessLayer.Models
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string DestinationName { get; set; }
        public virtual ICollection<TripLogModel> Trips { get; set; }
    }
}
