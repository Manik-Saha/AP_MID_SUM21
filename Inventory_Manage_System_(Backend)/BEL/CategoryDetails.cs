using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryDetails
    {
        public ICollection<CategoryModel> Categories { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
