using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Infra.IRepository
{
   public interface IRepository <T>
    {
        IList<T> Get();
        void Update(T model);
        void Delete(T model);
        void Create(T model);
        T GetById(Guid Id);
        void Save();

    }
}
