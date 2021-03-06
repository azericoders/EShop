﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Core;
using EShop.CoreAccess;

namespace EShop.Repository.MessageManager
{
    public class MessageRepository : IMessageRepository
    {
        EShopDbContext _context = new EShopDbContext();

        public void Dispose()
        {
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

        public IQueryable<Message> GetAll()
        {
            return _context.Messages;
        }

        public Message GetById(Guid id)
        {
            return _context.Messages.Find(id);
        }

        public void Save(Message company)
        {
            throw new NotImplementedException();
        }

        public void Update(Message company)
        {
            throw new NotImplementedException();
        }

        public Message DeleteById(Guid id)
        {
            var message = _context.Messages.Find(id);
            message.IsDelete = true;
            SaveChanges();
            return message;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
