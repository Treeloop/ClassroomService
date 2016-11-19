using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Treeloop.ClassroomService.WebService
{
    public class CategoryController : Controller
    {
        // GET all categories
        [HttpGet("product")]
        public IEnumerable<Category> Get()
        {
            return Repository.Categories;
        }
    }
}