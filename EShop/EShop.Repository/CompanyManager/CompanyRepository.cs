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
            return _context.Companies;
        }

        public Company GetById(Guid id)
        {
            var company = _context.Companies.Find(id);
            return company;

        }

        public void Save(Company company)
        {
            _context.Companies.Add(company);
            SaveChanges();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }

        public Company DeleteById(Guid id)
        {
            var company = _context.Companies.Find(id);
            company.IsDelete = true;
            SaveChanges();
            return company;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
