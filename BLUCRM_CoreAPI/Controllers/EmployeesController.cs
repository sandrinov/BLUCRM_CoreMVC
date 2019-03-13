using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLUCRM_CoreRepository;
using BLUCRM_CoreRepository.DTOs;
using BLUCRM_CoreRepository.EF;
using BLUCRM_CoreRepository.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BLUCRM_CoreAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeesController : ControllerBase
    {
        private IRepository _repository;
        private IFactory<Employees, DTO_Employee> _factory;

        public EmployeesController(IRepository repository, IFactory<Employees, DTO_Employee> factory)
        {
            _repository = repository;
            _factory = factory;
        }


        [HttpGet]
        [Route("api/allemployees", Name = "GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            IQueryable<Employees>  ef_employees = await _repository.GetAllEmployee();

            List<DTO_Employee> resultList = new List<DTO_Employee>();

            foreach (var entity in ef_employees)
            {
                resultList.Add(_factory.CreateDto(entity));
            }
            return Ok(resultList);
        }

    }
}