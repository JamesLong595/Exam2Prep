using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }
    }
}