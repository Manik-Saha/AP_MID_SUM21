using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        static CategoryService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        public static List<CategoryModel> GetAll()
        {
            var data = CategoryRepo.GetAll();
            var categories = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(data);
            return categories;
        }
    }
}
