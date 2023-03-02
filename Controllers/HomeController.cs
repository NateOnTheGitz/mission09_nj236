using Microsoft.AspNetCore.Mvc;
using mission09_nj236.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_nj236.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository temp) => repo = temp;

        public IActionResult Index()
        {
            var data = repo.Books.ToList();
            return View(data);
        }
    }
}
