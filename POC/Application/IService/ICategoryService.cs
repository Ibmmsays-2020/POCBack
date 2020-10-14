using POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.IService
{
   public interface ICategoryService 
    {
        string Create(Category category);
        Guid GetByName(string CategoryName);
        IList<Category> Get();
    }
}
