using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        
        public int VIN { get; set; }
        public int Year { get; set; }
    }
}