using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exam2Prep.DataAccess;
using Exam2Prep.Models;

namespace Exam2Prep.Controllers
{
    public class MaintainController : Controller
    {
        public ApplicationDbContext dbContext;

        public MaintainController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> Create(int vTypeId, int locId, int vin, int yr)
        {
            Vehicle newVeh = new Vehicle();
            newVeh.VehicleTypeId = vTypeId;
            newVeh.LocationId = locId;
            newVeh.VIN = vin;
            newVeh.Year = yr;

            dbContext.Vehicles.Add(newVeh);
            await dbContext.SaveChangesAsync();

            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> Update(int? vTypeId, int? locId, int vin, int? yr)
        {
            Vehicle veh1 = dbContext.Vehicles.Where(v => v.VIN == vin).First();

            if (vTypeId != null)
            {
                veh1.VehicleTypeId = (int)vTypeId;
            }

            if (locId != null)
            {
                veh1.LocationId = (int)locId;
            }

            if (yr != null)
            {
                veh1.VIN = vin;
            }

            if (yr != null)
            {
                veh1.Year = (int)yr;
            }

            dbContext.Vehicles.Update(veh1);
            await dbContext.SaveChangesAsync();

            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<ViewResult> Delete(int vin)
        {
            Vehicle veh1 = dbContext.Vehicles.Where(v => v.VIN == vin).First();
            
            dbContext.Vehicles.Remove(veh1);
            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
