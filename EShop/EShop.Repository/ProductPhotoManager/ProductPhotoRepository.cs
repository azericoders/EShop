using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.ProductPhotoManager
{
    public class ProductPhotoRepository : IProductPhotoRepository
    {
        EShopDbContext _context = new EShopDbContext();

        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<ProductPhoto> GetAll()
        {
            return _context.ProductPhotos;
        }

        public IQueryable<ProductPhoto> GetByProductId(Guid productId)
        {
            return _context.ProductPhotos.Where(photo => photo.ProductId == productId);
        }

        public ProductPhoto GetById(Guid id)
        {
            return _context.ProductPhotos.Find(id);
        }

        public void Save(ProductPhoto photo)
        {
            _context.ProductPhotos.Add(photo);
            SaveChanges();
        }

        public void Update(ProductPhoto photo)
        {
            throw new NotImplementedException();
        }

        public ProductPhoto DeleteById(Guid id)
        {
            var photo = _context.ProductPhotos.Find(id);
            photo.IsDelete = true;
            return photo;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
