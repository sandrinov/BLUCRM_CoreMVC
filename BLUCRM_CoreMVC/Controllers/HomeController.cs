using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLUCRM_CoreMVC.Models;

namespace BLUCRM_CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        Repository.EF_Repository _repository;
        public HomeController()
        {
            _repository = new Repository.EF_Repository();
        }
        public IActionResult Index()
        {

            return View(_repository.GetAllEmployee());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
