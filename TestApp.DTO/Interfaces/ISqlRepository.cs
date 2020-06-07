using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.DTO;
using TestApp.DAL.Extentions;

namespace TestApp.DAL.Interfaces
{
   public interface ISqlRepository
    {
        (bool IsError, string Message,List<EmployeeDTO> Values) GetAllEmployeesWithResult();
        (bool IsError, string Message, List<EmployeeDTO> Values) GetEmployeesByIdWithResult();
        (bool IsError, string Message) SetEmployeeWithResult(EmployeeDTO employeeDTO);

        (bool IsError, string Message, List<DepartmentDTO> Values) GetAllDepartmentsWithResult();
        (bool IsError, string Message, List<DepartmentDTO> Values) GetDepartmentsByIdWithResult();
        (bool IsError, string Message) SetDepartmentWithResult(DepartmentDTO departmentDTO);

        (bool IsError, string Message, List<OrderDTO> Values) GetAllOrdersWithResult();
        (bool IsError, string Message, List<OrderDTO> Values) GetOrdersByIdWithResult();
        (bool IsError, string Message) SetDepartmentWithResult(OrderDTO orderDTO);

    }
}
