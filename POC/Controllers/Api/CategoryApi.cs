using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.Application.IService;
using POC.Models;

namespace POC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApi : ControllerBase
    {
        ICategoryService categoryService;
        public CategoryApi(ICategoryService _categoryService)
        {
            this.categoryService = _categoryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IList<Category> categories= categoryService.Get();
            return Ok(new { Result = categories });
        }
    }
}
