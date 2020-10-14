using POC.Application.IService;
 using POC.Infra.IRepository;
using POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.Service
{
    public class ProductService : IProductService
    {
        IRepository<Product> Repository;
        IImageService ImageServcie;
        public ProductService(IRepository<Product> _repo, IImageService _ImageServcie)
        {
            this.Repository = _repo;
            this.ImageServcie = _ImageServcie;
        }

        public void Create(Product product)
        {
           product.Id = new Guid();
            List<string> Paths = ImageServcie.UploadPhoto(product.FormFiles);
            foreach (var path in Paths)
            {
                Images image = new Images();
                image.ProductId = product.Id;
                image.FullPath = path;
                ImageServcie.Create(image);
            }
            Repository.Create(product);
        }

        public IList<Product> Get()
        {
            IList<Product> products = Repository.Get();
            return products;
        }
    }
}
