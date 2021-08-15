using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ProductService
    {
        static ProductService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static List<string> GetProductNames()
        {
            return ProductRepo.GetProductNames();
        }
        public static List<ProductModel> GetAllProduct()
        {
            var data = ProductRepo.GetAllProducts();
            var dataDetails = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(data);
            return dataDetails;
        }
        public static void AddProduct(ProductModel p)
        {
            var pro = AutoMapper.Mapper.Map<ProductModel, Product>(p);
            ProductRepo.AddProduct(pro);
        }

        public static ProductDetails GetProductDetails(int id)
        {
            var p = ProductRepo.GetProductDetails(id);
            var pro = AutoMapper.Mapper.Map<Product, ProductDetails>(p);
            return pro;
        }
    }
}
