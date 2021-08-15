using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static InventoryManagementSystemEntities context;
        static CategoryRepo()
        {
            context = new InventoryManagementSystemEntities();
        }
        public static List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
