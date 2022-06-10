using HomeTask_BizLand.DAL;
using HomeTask_BizLand.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask_BizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel {
                categories=db.Categories.Include(x=>x.Projects).ToList(),
                projects=db.Projects.Include(x=>x.Category).ToList()
            };
            return View(model);
        }

    }
}
