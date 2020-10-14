using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.Application.IService;

namespace POC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageApi : ControllerBase
    {
        IImageService imageService;
        public ImageApi(IImageService _imageService)
        {
            this.imageService = _imageService;
        }

        [HttpPost]
        public IActionResult Create(IFormFile [] formFiles)
        {
            imageService.UploadPhoto(formFiles);
            return Ok(new { Result = "Done" });
        }
    }
}
