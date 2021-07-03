using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Status
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CategoryId { get; set; }
    }
}