using BLUCRM_CoreRepository.DTOs;
using BLUCRM_CoreRepository.EF;
using BLUCRM_CoreRepository.Factories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLUCRM_CoreRepository
{
    public class EF_Repository : IRepository
    {
        NorthwindContext _context;
        IFactory<Employees, DTO_Employee> _factory;

        public EF_Repository(IFactory<Employees, DTO_Employee> factory)
        {
            _context = new NorthwindContext();
            _factory = factory;
        }
        //public List<DTO_Employee> GetAllEmployee()
        //{
        //    List<Employees> lst = _context.Employees.ToList();

        //    List<DTO_Employee> resultList = new List<DTO_Employee>();

        //    foreach (Employees entity in lst)
        //    {
        //        resultList.Add(_factory.CreateDto(entity));
        //    }
        //    return resultList;
        //}

        //public DTO_Employee GetEmployeeByID(int EmployeeID)
        //{
        //    var entity = _context.Employees.Where(e => e.EmployeeId == EmployeeID).FirstOrDefault();

        //    return _factory.CreateDto(entity);
        //}

        public async Task<IQueryable<Employees>> GetAllEmployee()
        {
            return await Task.Run(() =>
            {
                try
                {
                    IQueryable<Employees> result = _context.Employees.OrderBy(p => p.LastName).AsQueryable();
                    return result;
                }
                catch (Exception ex)
                {


                }
                return null;
            });
        }

        public async Task<Employees> GetEmployeeByID(int EmployeeID)
        {
            var result = _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == EmployeeID);
            return await result;
        }
    }
}
