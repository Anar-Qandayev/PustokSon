using Microsoft.AspNetCore.Mvc;
using Task2P.DAL;
using Task2P.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokAP205.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Sliders> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
