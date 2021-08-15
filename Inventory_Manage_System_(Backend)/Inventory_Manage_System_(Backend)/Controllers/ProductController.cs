using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace Inventory_Manage_System__Backend_.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/product/productNames")]
        [HttpGet]
        public List<string> GetProductNames()
        {
            return ProductService.GetProductNames();
        }
        [Route("api/product/all")]
        [HttpGet]
        public static List<ProductModel> GetAllProduct()
        {
            return ProductService.GetAllProduct();
        }
        [Route("api/product/add")]
        [HttpPost]
        public void Add(ProductModel p)
        {
            ProductService.AddProduct(p);
        }
        [Route("api/Product/{id}/Details")]
        [HttpGet]
        public ProductDetails GetProductDetails(int id)
        {
            return ProductService.GetProductDetails(id);
        }
    }
}
