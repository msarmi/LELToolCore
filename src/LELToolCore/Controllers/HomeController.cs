using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LELToolCore.DAL;
using LELToolCore.Models;

namespace LELToolCore.Controllers
{
    public class HomeController : Controller
    {
		private LELContext Context { get; set; }
		public HomeController(LELContext context) {
			Context = context;
		}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

		public IActionResult DoAnithing() {
			
				Symbol sym = new Symbol() { Id = 21};

				Context.Symbols.Add(sym);
				Context.SaveChanges();
			
			return View("Index");
		}
    }
}
