﻿using System;
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
        EShopDbContext context = new EShopDbContext();
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public IQueryable<Category> GetAll()
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
    }
}