using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.ProductManager
{
    public class ProductRepository : IProductRepository
    {
        EShopDbContext _context = new EShopDbContext();
        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product company)
        {
            throw new NotImplementedException();
        }

        public Product DeleteById(Guid id)
        {
            var product = _context.Products.Find(id);
            product.IsDelete = true;
            SaveChanges();
            return product;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
