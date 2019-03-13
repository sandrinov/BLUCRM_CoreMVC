using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLUCRM_CoreMVC.Models;
using BLUCRM_CoreMVC.Repository;
using System.Net.Http;
using Newtonsoft.Json;
using BLUCRM_CoreMVC.DTOs;

namespace BLUCRM_CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        readonly HttpClient _httpClient;
        //IRepository _repository;
        public HomeController(HttpClient httpClient/*IRepository repository*/)
        {
            _httpClient = httpClient;
            // _repository = repository;
            //RepositoryFactory repositoryFactory = new RepositoryFactory();
            //_repository = RepositoryFactory.GetRepository();
        }
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage apiResponse = await _httpClient.GetAsync("/api/allemployees");

            switch (apiResponse.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    {
                        string content = await apiResponse.Content.ReadAsStringAsync();
                       
                        var dtoResultList = JsonConvert.DeserializeObject<List<DTO_Employee>>(content);
                       
                        return View(dtoResultList);
                    }
                case System.Net.HttpStatusCode.Unauthorized:
                    {
                        //HttpContext.Session.Clear();
                        return Redirect("/Home/Index");
                    }
                default:
                    return Redirect("/Home/Error");
            }

            //return View(_repository.GetAllEmployee());
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
