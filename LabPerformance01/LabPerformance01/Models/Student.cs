using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabPerformance01.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public double CGPA { get; set; }
    }
}