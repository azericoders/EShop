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
            return _context.Categories;
        }

        public IQueryable<Category> GetAllMainCategory()
        {
            return _context.Categories;
        }

        public IQueryable<Category> GetAllChildCategory()
        {
            return _context.Categories;
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Category category)
        {
            _context.Categories.Add(category);
            SaveChanges();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Category DeleteById(Guid id)
        {
            var category = _context.Categories.Find(id);
            category.IsDelete = true;
            SaveChanges();
            return category;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}
