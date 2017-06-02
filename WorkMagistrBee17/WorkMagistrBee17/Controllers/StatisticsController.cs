using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using WMB.Data;
using System.Linq;
using WMB.Data.IRepositorys;
using WorkMagistrBee17.Models;
using System;
using System.Collections.Generic;
using WMB.Data.DataContext.DataAnalyst;

namespace WorkMagistrBee17.Controllers
{
    public class StatisticsController : Controller
    {
        private ApplicationDbContext db;
        public StatisticsController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.EffectivenessHivess.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            var ee = await db.EffectivenessHivess.ToListAsync();
            var model = List<BeehiveListModel>(ee);
            //var item111 = ee.OrderByDescending(x => x.NameHive).Take(1).FirstOrDefault();

            var movies = from m in db.Beehives select m;
            //movies = movies.Where(s => s.Coefficientefficiency.Contains(id));

         
            return View(ee);
        }

        private object List<T>(List<EffectivenessHives> ee)
        {
            throw new NotImplementedException();
        }

        //public async Task<IActionResult> Create1 ()
        //{
        //    IRepository repo;
        //    var items = db.Beehives.Where(p => p.Coefficientefficiency < (p.TypeBees=10));

        //    foreach (var it in items)
        //    {
        //        item.Course_Price = item.Price * it.Exchange;

        //    }

        //}
    }
}