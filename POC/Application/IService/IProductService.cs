 using POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.IService
{
    public interface IProductService
    {
        void Create(Product product);
        IList<Product> Get();
    }
}
