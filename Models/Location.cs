using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string DealerName { get; set; }
        public string ZipCode { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }
    }
}