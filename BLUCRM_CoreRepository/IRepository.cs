using BLUCRM_CoreRepository.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLUCRM_CoreRepository
{
    public interface IRepository
    {
        List<DTO_Employee> GetAllEmployee();
        DTO_Employee GetEmployeeByID(int EmployeeID);
    }
}
