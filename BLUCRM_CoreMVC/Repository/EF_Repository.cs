using BLUCRM_CoreMVC.DTOs;
using BLUCRM_CoreMVC.Factories;
using BLUCRM_CoreMVC.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLUCRM_CoreMVC.Repository
{
    public class EF_Repository : IRepository
    {
        NorthwindContext _context;
        IFactory<BLUCRM_CoreMVC.Repository.EF.Employees, BLUCRM_CoreMVC.DTOs.DTO_Employee> _factory;

        public EF_Repository(IFactory<BLUCRM_CoreMVC.Repository.EF.Employees, BLUCRM_CoreMVC.DTOs.DTO_Employee> factory)
        {
            _context = new NorthwindContext();
            _factory = factory; 
        }
        public List<DTO_Employee> GetAllEmployee()
        {
            List<Employees> lst = _context.Employees.ToList();

            List<DTO_Employee> resultList = new List<DTO_Employee>();

            foreach (Employees entity in lst)
            {
                resultList.Add(_factory.CreateDto(entity));
            }
            return resultList;
        }

        public DTO_Employee GetEmployeeByID(int EmployeeID)
        {
            var entity = _context.Employees.Where(e => e.EmployeeId == EmployeeID).FirstOrDefault();

            return _factory.CreateDto(entity);
        }

    }
}
