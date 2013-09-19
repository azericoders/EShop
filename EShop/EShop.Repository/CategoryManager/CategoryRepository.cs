using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.CategoryManager
{
    public class CategoryRepository : ICategoryRepository
    {
        EShopDbContext _context = new EShopDbContext();
        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Category company)
        {
            throw new NotImplementedException();
        }

        public void Update(Category company)
        {
            throw new NotImplementedException();
        }

        public Category DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
