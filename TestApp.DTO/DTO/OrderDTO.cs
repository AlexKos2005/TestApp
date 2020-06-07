using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApp.DTO.DTO
{
  public class OrderDTO
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int EmployeeId { get; set; }
    }
}
