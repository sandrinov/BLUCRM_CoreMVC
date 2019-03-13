using BLUCRM_CoreRepository.DTOs;
using BLUCRM_CoreRepository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLUCRM_CoreAPI.Factories
{
    public class EmployeeFactory : IFactory<Employees, DTO_Employee>
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
