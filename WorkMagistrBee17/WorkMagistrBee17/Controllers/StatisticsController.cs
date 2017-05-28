using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using WMB.Data;

namespace WorkMagistrBee17.Controllers
{
    public class StatisticsController : Controller
    {
        private ApplicationDbContext db;
        public StatisticsController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}