using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using WMB.Data;

namespace WorkMagistrBee17.Controllers
{
    public class MyApiaryController : Controller
    {
        private ApplicationDbContext db;
        public MyApiaryController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexError()
        {
            return View();
        }
    }
}