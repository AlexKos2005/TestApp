using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DAL.DTO;
using TestApp.DAL.Interfaces;

namespace TestApp.DTO.Services
{
    public class MySqlRepository : ISqlRepository
    {

        private DataContext _dataContext;

        public MySqlRepository()
        {
            _dataContext = new DataContext();
        }

        public (bool IsError, string Message, List<DepartmentDTO> Values) GetAllDepartmentsWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<EmployeeDTO> Values) GetAllEmployeesWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<OrderDTO> Values) GetAllOrdersWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<DepartmentDTO> Values) GetDepartmentsByIdWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<EmployeeDTO> Values) GetEmployeesByIdWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<OrderDTO> Values) GetOrdersByIdWithResult()
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message) SetDepartmentWithResult(DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message) SetDepartmentWithResult(OrderDTO orderDTO)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message) SetEmployeeWithResult(EmployeeDTO employeeDTO)
        {
            throw new NotImplementedException();
        }


    }
}
