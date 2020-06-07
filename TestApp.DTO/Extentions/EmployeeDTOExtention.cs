using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Core.Entities;
using TestApp.DAL.DTO;

namespace TestApp.DAL.Extentions
{
   public static class EmployeeDTOExtention
    {
        public static Employee ToModel (this EmployeeDTO employeeDTO)
        {
            return new Employee()
            {
                Id=employeeDTO.Id,
                FirstName=employeeDTO.FirstName,
                LastName=employeeDTO.LastName,
                Patronymic=employeeDTO.Patronymic,
                BirthDate=employeeDTO.BirthDate,
                Gender=employeeDTO.Gender,
                DepartmentId=employeeDTO.DepartmentId,
            };
        }

        public static EmployeeDTO FromModel(this Employee employee)
        {
            return new EmployeeDTO()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Patronymic = employee.Patronymic,
                BirthDate = employee.BirthDate,
                Gender = employee.Gender,
                DepartmentId = employee.DepartmentId,
            };
        }
    }
}
