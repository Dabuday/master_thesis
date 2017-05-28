using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using WMB.Data;

namespace WorkMagistrBee17.Controllers
{
    public class CollectionController : Controller
    {
        private ApplicationDbContext db;
        public CollectionController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index(string sortOrder, string searchString, ProductTypeCollection productTypeCollection)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["WeightSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Weight_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            var beehives = from s in db.ProductTypeCollections select s;

            if (!String.IsNullOrEmpty(searchString)){
                beehives = beehives.Where(s => s.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    beehives = beehives.OrderByDescending(s => s.Name);
                    break;
                case "Weight_desc":
                    beehives = beehives.OrderByDescending(s => s.Weight);
                    break;
                case "Date":
                    beehives = beehives.OrderBy(s => s.zDataZbory);
                    break;
                case "date_desc":
                    beehives = beehives.OrderByDescending(s => s.zDataZbory);
                    break;
                default:
                    beehives = beehives.OrderBy(s => s.Name);
                    break;
            }
            return View(await beehives.AsNoTracking().ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductTypeCollection productTypeCollection)
        {
            try
            {
                db.ProductTypeCollections.Add(productTypeCollection);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Во время створення возникли ошибки";
                return RedirectToAction("Index");
            }
           
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null){
                ProductTypeCollection productTypeCollection = await db.ProductTypeCollections.FirstOrDefaultAsync(p => p.Id == id);
                if (productTypeCollection != null)
                    return View(productTypeCollection);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductTypeCollection productTypeCollection)
        {
            try
            {
                db.ProductTypeCollections.Update(productTypeCollection);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Во время просмотра возникли ошибки";
                return RedirectToAction("Index");
            }

            
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                ProductTypeCollection productTypeCollection = await db.ProductTypeCollections.FirstOrDefaultAsync(p => p.Id == id);
                if (productTypeCollection != null)
                    return View(productTypeCollection);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                ProductTypeCollection productTypeCollection = await db.ProductTypeCollections.FirstOrDefaultAsync(p => p.Id == id);
                if (productTypeCollection != null)
                {
                    db.ProductTypeCollections.Remove(productTypeCollection);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
