using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLUCRM_CoreMVC.DTOs;
using BLUCRM_CoreMVC.Repository.EF;

namespace BLUCRM_CoreMVC.Factories
{
    public class EmployeeFactory : IFactory<BLUCRM_CoreMVC.Repository.EF.Employees, BLUCRM_CoreMVC.DTOs.DTO_Employee>
    {
        public DTO_Employee CreateDto(Employees entity)
        {
            return new DTO_Employee()
            {
                EmployeeID = entity.EmployeeId,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }

        public Employees CreateEntity(DTO_Employee dto)
        {
            return new Employees()
            {
                LastName = dto.LastName,
                FirstName = dto.FirstName,
                EmployeeId = dto.EmployeeID
            };
        }
    }
}
