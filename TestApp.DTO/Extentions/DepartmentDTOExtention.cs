using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Core.Entities;
using TestApp.DAL.DTO;


namespace TestApp.DAL.Extentions
{
   public static class DepartmentDTOExtention
    {
        public static Department ToModel (this DepartmentDTO departmentDTO)
        {
            return new Department()
            {
                Id = departmentDTO.Id,
                Name=departmentDTO.Name,
                EmployeeId=departmentDTO.EmployeeId
            };
        }

        public static DepartmentDTO FromModel(this Department department)
        {
            return new DepartmentDTO()
            {
                Id = department.Id,
                Name = department.Name,
                EmployeeId = department.EmployeeId
            };
        }
    }
}
