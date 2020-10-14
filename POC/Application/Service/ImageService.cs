using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using POC.Application.IService;
using POC.Infra.IRepository;
using POC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.Service
{
    public class ImageService : IImageService
    {
        IRepository<Images> Repo;
        IHostingEnvironment ev;
        public ImageService(IRepository<Images> _Repo, IHostingEnvironment _ev)
        {
            this.Repo = _Repo;
            this.ev = _ev;
        }
        public void Create(Images image)
        {
            image.Id = new Guid();
            Repo.Create(image);
        }

        public List<string> UploadPhoto(IFormFile[] FormFiles)
        {
            List<string> Paths = new List<string>();
            var Directory = ev.ContentRootPath;
            Directory = Directory + "\\Resources\\";

            try
            {
                foreach (var formFile in FormFiles)
                {
                    var FileName = Path.GetFileNameWithoutExtension(formFile.FileName);
                    var Extension = Path.GetExtension(formFile.FileName);
                    string FullPath = FileName + Extension;
                    Paths.Add(FullPath);
                    string path = Path.Combine(Directory, FullPath);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        formFile.CopyTo(fileStream);
                    }
                }
                return Paths;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
