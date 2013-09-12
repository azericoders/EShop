using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> GetAll();
        void Save(T company);
        void Update(T company);
        T DeleteById(Guid id);
    }
}
