using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Core.Entities;
using TestApp.DAL.DTO;

namespace TestApp.DAL.Extentions
{
   public static class OrderDTOExtention
    {
        public static Order ToModel(this OrderDTO orderDTO)
        {
            return new Order()
            {
                Id=orderDTO.Id,
                Number=orderDTO.Number,
                EmployeeId=orderDTO.EmployeeId,
            };
        }

        public static OrderDTO FromModel(this Order order)
        {
            return new OrderDTO()
            {
                Id = order.Id,
                Number = order.Number,
                EmployeeId = order.EmployeeId,
            };
        }
    }
}
