using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
            return context.Users;
        }

        public User GetById(Guid id)
        {
            return context.Users.Find(id);
        }

        public User GetUserByNameAndPassword(string logname, string password)
        {
            return context.Users.SingleOrDefault(user => user.LoginName == logname && user.Password == password);
        }

        public void Save(User user)
        {
            context.Users.Add(user);
            SaveChanges();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            //try
            //{
            context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
    }
}
