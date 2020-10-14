using Microsoft.AspNetCore.Http;
using POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.IService
{
  public  interface IImageService
    {
        List<string> UploadPhoto(IFormFile[] FormFile);
        void Create(Images images);
    }
}
