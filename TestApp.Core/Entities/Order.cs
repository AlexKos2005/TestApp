using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Core.Entities
{
   public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int EmployeeId { get; set; }
    }
}
