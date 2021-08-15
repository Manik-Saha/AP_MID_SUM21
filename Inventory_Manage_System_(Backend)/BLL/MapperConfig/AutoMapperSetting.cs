using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSetting : Profile
    {
        public AutoMapperSetting()
        {
            CreateMap<Category, CategoryModel>();
            CreateMap<Category, CategoryDetails>();
            CreateMap<Product, ProductModel>();
            CreateMap<Product, ProductDetails>();
        }
    }
}
