﻿using System;
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
        EShopDbContext context = new EShopDbContext();
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public IQueryable<Company> GetAll()
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
    }
}