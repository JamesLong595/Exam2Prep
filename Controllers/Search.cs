using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exam2Prep.DataAccess;
using Exam2Prep.Models;
using System.Data;

namespace Exam2Prep.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public SearchController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(string? vMake = null, string? vModel = null, string? zip = null)
        {
            var results = from v in dbContext.Vehicles
                          join t in dbContext.VehicleTypes on v.VehicleTypeId equals t.VehicleTypeId
                          join l in dbContext.Locations on v.LocationId equals l.LocationId
                          select new SearchResult {
                              VIN = v.VIN,
                              Make = t.Make,
                              Model = t.Model,
                              Year = v.Year,
                              DealerName = l.DealerName,
                              ZipCode = l.ZipCode
                          };

            if (!string.IsNullOrEmpty(vMake))
            {
                results = results.Where(v => v.Make == vMake);
            }

            if (!string.IsNullOrEmpty(vModel))
            {
                results = results.Where(v => v.Model == vModel);
            }

            if (!string.IsNullOrEmpty(zip))
            {
                results = results.Where(v => v.ZipCode == zip);
            }

            SearchResults vList = new SearchResults();
            
            vList.data = results.ToList();

            return View(vList);
        }
    }
}