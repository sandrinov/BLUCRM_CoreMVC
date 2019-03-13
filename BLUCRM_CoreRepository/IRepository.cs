using BLUCRM_CoreRepository.DTOs;
using BLUCRM_CoreRepository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLUCRM_CoreRepository
{
    public interface IRepository
    {

        Task<IQueryable<Employees>> GetAllEmployee();
        Task<Employees> GetEmployeeByID(int EmployeeID);
    }
}
