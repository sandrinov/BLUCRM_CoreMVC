using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLUCRM_CoreMVC.Models;
using BLUCRM_CoreMVC.Repository;

namespace BLUCRM_CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
            //RepositoryFactory repositoryFactory = new RepositoryFactory();
            //_repository = RepositoryFactory.GetRepository();
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
