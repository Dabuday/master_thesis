using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using WMB.Data;

namespace WorkMagistrBee17.Controllers
{
    public class BeeHiveController : Controller
    {
        private ApplicationDbContext db;
        public BeeHiveController(ApplicationDbContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Beehives.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Beehive beehive)
        {
            try
            {
                db.Beehives.Add(beehive);
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
            if (id != null)
            {
                Beehive beehive = await db.Beehives.FirstOrDefaultAsync(p => p.Id == id);
                if (beehive != null)
                    return View(beehive);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Beehive beehive)
        {
            try
            {
                db.Beehives.Update(beehive);
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
                Beehive beehive = await db.Beehives.FirstOrDefaultAsync(p => p.Id == id);
                if (beehive != null)
                    return View(beehive);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Beehive beehive = await db.Beehives.FirstOrDefaultAsync(p => p.Id == id);
                if (beehive != null)
                {
                    db.Beehives.Remove(beehive);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}