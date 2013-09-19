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
        EShopDbContext _context = new EShopDbContext();

        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.Where(user => user.IsDelete == false);
        }

        public User GetById(Guid id)
        {
            return _context.Users.Find(id);
        }

        public User GetUserByNameAndPassword(string logname, string password)
        {
            return _context.Users.SingleOrDefault(user => user.LoginName == logname && user.Password == password);
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteById(Guid id)
        {
            var user = _context.Users.Find(id);
            user.IsDelete = true;
            SaveChanges();

            return user;
        }

        public void SaveChanges()
        {
            //try
            //{
            _context.SaveChanges();
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
