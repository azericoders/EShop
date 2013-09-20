using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;

namespace EShop.Repository.ProductPhotoManager
{
    public interface IProductPhotoRepository:IRepository<ProductPhoto>
    {
        IQueryable<ProductPhoto> GetByProductId(Guid productId);
    }
}
