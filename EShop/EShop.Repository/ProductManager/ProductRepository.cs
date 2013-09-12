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
        EShopDbContext context = new EShopDbContext();
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Product company)
        {
            throw new NotImplementedException();
        }

        public void Update(Product company)
        {
            throw new NotImplementedException();
        }

        public Product DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
