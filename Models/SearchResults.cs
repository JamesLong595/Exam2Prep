using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2Prep.Models
{
    public class SearchResults
    {
        public ICollection<SearchResult> data { get; set; }
    }

    public class SearchResult
    {
        public int VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string DealerName { get; set; }
        public string ZipCode { get; set; }
    }
}