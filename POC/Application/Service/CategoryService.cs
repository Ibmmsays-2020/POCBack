using POC.Application.IService;
using POC.Infra.IRepository;
using POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Application.Service
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category > Repository;

        public CategoryService(IRepository<Category > _Repository)
        {
            this.Repository = _Repository;
        }
        public string Create(Category category)
        {
            category.Id = new Guid();
            Repository.Create(category);
            return category.Name;
        }

        public IList<Category> Get()
        {
           return Repository.Get();
        }

        public Guid GetByName(string CategoryName)
        {
            return Get().Where(c => c.Name.ToLower().Trim() == CategoryName.ToLower().Trim()).Select(c => c.Id).FirstOrDefault();
        }
    }
}
