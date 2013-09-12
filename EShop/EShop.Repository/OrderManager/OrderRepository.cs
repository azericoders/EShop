using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.OrderManager
{
    public class OrderRepository : IOrderRepository
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

        public IQueryable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Order company)
        {
            throw new NotImplementedException();
        }

        public void Update(Order company)
        {
            throw new NotImplementedException();
        }

        public Order DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
