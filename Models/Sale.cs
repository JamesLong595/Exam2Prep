using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class Sale
    {
        [Key]
        public int TransactionId { get; set; }
        
        public int SalesPersonId { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }

        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        
        public DateTime SaleDate { get; set; }
    }
}