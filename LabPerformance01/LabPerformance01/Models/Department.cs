using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabPerformance01.Models
{
    public class Department
    {
        public int Dept_ID { get; set; }
        [Required]
        public string Dept_Name { get; set; }
    }
}