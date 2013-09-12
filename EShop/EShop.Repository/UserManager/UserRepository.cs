using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.UserManager
{
    public class UserRepository : IUserRepository
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

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(User company)
        {
            throw new NotImplementedException();
        }

        public void Update(User company)
        {
            throw new NotImplementedException();
        }

        public User DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
