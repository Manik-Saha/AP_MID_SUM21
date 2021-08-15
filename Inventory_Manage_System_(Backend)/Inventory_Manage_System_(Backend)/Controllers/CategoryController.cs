using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Inventory_Manage_System__Backend_.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/{id}/Details")]
        [HttpGet]
        public CategoryDetails GetCategoryDetails()
        {
            return null;
        }
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAll()
        {
            return CategoryService.GetAll();
        }
    }
}
