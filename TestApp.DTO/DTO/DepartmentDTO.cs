﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApp.DAL.DTO
{
   public class DepartmentDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
    }
}
