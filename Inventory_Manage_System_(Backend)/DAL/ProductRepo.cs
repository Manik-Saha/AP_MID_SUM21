using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static InventoryManagementSystemEntities context;
        static ProductRepo()
        {
            context = new InventoryManagementSystemEntities();
        }
        public static List<string> GetProductNames()
        {
            var data = context.Products.Select(e =>e.Name).ToList();
            return data;
        }
        public static List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }
        public static void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public static Product GetProductDetails(int id)
        {
            return context.Products.FirstOrDefault(e => e.Id == id);
        }
    }
}
