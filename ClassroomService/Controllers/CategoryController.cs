using System;
using System.Collections.Generic;
using ClassroomService.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomService.Controllers
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
