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
        EShopDbContext _context = new EShopDbContext();
        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders;
        }

        public Order GetById(Guid id)
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

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
