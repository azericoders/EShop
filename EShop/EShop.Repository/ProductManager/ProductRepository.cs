﻿using System;
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
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
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

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
