﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;

namespace EShop.Repository.CategoryManager
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IQueryable<Category> GetAllMainCategory();
        IQueryable<Category> GetAllChildCategory();
    }
}
