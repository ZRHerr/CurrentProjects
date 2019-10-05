using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackerTemplate.Models;
using TrackerTemplate.Models.AccountViewModels;

namespace TrackerTemplate.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> userManager;

        public VehiclesController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var currentUserId = userManager.GetUserId(User);

            ViewData["BrandSortParm"] = String.IsNullOrEmpty(sortOrder) ? "brand_desc" : "";
            ViewData["ModelSortParm"] = sortOrder == "Model" ? "model_desc" : "Model";
            ViewData["CurrentFilter"] = searchString;

            var cars = from s in _context.Vehicles.Where(x => x.UserId == currentUserId)
                       select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Brand.Contains(searchString)
                                       || s.Model.Contains(searchString));
            }

            cars = sortOrder switch
            {
                "brand_desc" => cars.OrderByDescending(s => s.Brand),
                "Model" => cars.OrderBy(s => s.Model),
                "model_desc" => cars.OrderByDescending(s => s.Model),
                _ => cars.OrderBy(s => s.Brand),
            };
            return View(await cars.AsNoTracking().ToListAsync());
        }

        // GET: Vehicles/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            var currentUserId = userManager.GetUserId(User);

            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Vehicles
                .Include(c => c.ServiceBooks)
                .ThenInclude(s => s.ServiceBookLog)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.VehicleId == id);

            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Vehicles/Create

        public IActionResult Create()
        {
            var currentUserId = userManager.GetUserId(User);

            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vehicle car, IFormFile image)
        {
            var currentUserId = userManager.GetUserId(User);

            if (ModelState.IsValid)
            {
                car.UserId = currentUserId;

                if (image != null && image.Length > 0)
                {
                    var fileName = string.Empty;

                    if (car.UserId != null)
                    {
                        fileName = $"{car.Brand}_{car.Model}_{car.UserId}.{image.FileName.Split('.').Last()}";
                    }
                    else
                    {
                        fileName = $"{car.Brand}_{car.Model}_null.{image.FileName.Split('.').Last()}";
                    }
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\carimages", fileName);
                    using (var fileSteam = new FileStream(filePath, FileMode.Create))
                    {
                        await image.CopyToAsync(fileSteam);
                    }
                    car.Image = fileName;
                }

                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Vehicles/Edit/5
        
        public async Task<IActionResult> Edit(int? id)
        {
            var currentUserId = userManager.GetUserId(User);

            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Vehicles.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Vehicle car, IFormFile image)
        {
            var currentUserId = userManager.GetUserId(User);

            if (id != car.GetVehicleId())
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (image != null && image.Length > 0)
                    {
                        var fileName = string.Empty;

                        if (car.UserId != null)
                        {
                            fileName = $"{car.Brand}_{car.Model}_{car.UserId}.{image.FileName.Split('.').Last()}";
                        }
                        else
                        {
                            fileName = $"{car.Brand}_{car.Model}_null.{image.FileName.Split('.').Last()}";
                        }
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\carimages", fileName);
                        using (var fileSteam = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileSteam);
                        }
                        car.Image = fileName;
                    }
                    else
                    {
                        string currentUserIdString = string.Empty;

                        if (car.UserId == null)
                        {
                            currentUserIdString = "null";
                        }
                        else
                        {
                            currentUserIdString = car.UserId.ToString();
                        }

                        foreach (var carImage in _context.Vehicles.Select(x => x.Image))
                        {
                            if (carImage.Split('.').First().Split('_').Last() == currentUserIdString && carImage.Split('.').First().Split('_').First() == car.Brand
                                && carImage.Split('.').First().Split('_')[1] == car.Model)
                            {
                                car.Image = carImage;
                            }
                        }
                    }

                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(car.GetVehicleId()))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Vehicles/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            var currentUserId = userManager.GetUserId(User);

            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Vehicles
                .FirstOrDefaultAsync(m => m.VehicleId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currentUserId = userManager.GetUserId(User);

            string currentUserIdString = string.Empty;

            if (currentUserId == null)
            {
                currentUserIdString = "null";
            }
            else
            {
                currentUserIdString = currentUserId.ToString();
            }

            string rootFolder = @"wwwroot\\images\\carimages\\";

            foreach (var carImage in _context.Vehicles.Select(x => x.Image))
            {
                if (carImage.Split('.').First().Split('_').Last() == currentUserIdString)
                {
                    try
                    {
                        System.IO.File.Delete(Path.Combine(rootFolder, carImage));
                    }
                    catch (IOException)
                    {
                    }
                }

            }

            var car = await _context.Vehicles.FindAsync(id);
            _context.Vehicles.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleId == id);
        }
    }
}
