using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.CompanyManager
{
    public class CompanyRepository : ICompanyRepository
    {
        EShopDbContext _context = new EShopDbContext();
        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Company company)
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }

        public Company DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
