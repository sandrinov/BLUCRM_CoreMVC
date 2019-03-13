using BLUCRM_CoreMVC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLUCRM_CoreMVC.Repository
{
    public interface IRepository
    {
        List<DTO_Employee> GetAllEmployee();
        DTO_Employee GetEmployeeByID(int EmployeeID);
    }
}
