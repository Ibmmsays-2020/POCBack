using POC.AppDBContext;
using POC.Infra.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Infra.Reopsitory
{
    public class Repository<T> : IRepository<T> where T : class
    {
        PocContext PocContext;
        public Repository(PocContext _PocContext)
        {
            this.PocContext = _PocContext;
        }
        public void Create(T model)
        {
            PocContext.Set<T>().Add(model);
            Save();
        }
        public void Delete(T model)
        {
            PocContext.Remove(model);
            Save();
        }
        public void Update(T model)
        {
            PocContext.Set<T>().Update(model);
            Save();
        }

        public IList<T> Get()
        {
            return PocContext.Set<T>().ToList();
        }

        public T GetById(Guid Id)
        {
            return PocContext.Set<T>().Find(Id);
        }


        public void Save()
        {
            PocContext.SaveChanges();
        }


    }
}
