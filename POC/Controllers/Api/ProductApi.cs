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
    public class ProductApi : ControllerBase
    {
        IProductService productService;
        public ProductApi(IProductService _productService)
        {
            this.productService = _productService;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product == null)
            {
                return Ok(new { Result = "Invalid Data" });
            }
            else
            {
                try
                {
                    productService.Create(product);
                    return Ok(new { Result = product });
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            IList<Product> products =  productService.Get();
            return Ok(new { Result = products });

        }

    }
}
