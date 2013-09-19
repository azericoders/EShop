using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.OrderLineManager
{
    public class OrderLineRepository : IOrderLineRepository
    {
        EShopDbContext context = new EShopDbContext();
        public void Dispose()
        {
            if (context == null) return;
            context.Dispose();
            context = null;
        }

        public IQueryable<OrderLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderLine GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(OrderLine company)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderLine company)
        {
            throw new NotImplementedException();
        }

        public OrderLine DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
