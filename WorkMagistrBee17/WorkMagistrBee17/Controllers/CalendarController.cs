using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WMB.Data;

namespace WorkMagistrBee17.Controllers
{
    public class CalendarController : Controller
    {
        private ApplicationDbContext db;
        public CalendarController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}