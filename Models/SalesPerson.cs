using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class SalesPerson
    {
        [Key]
        public int SalesPersonId { get; set; }
        
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Sale> Sales { get; set; }
    }
}