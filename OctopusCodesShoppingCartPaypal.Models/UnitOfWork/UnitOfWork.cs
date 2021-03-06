﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OctopusCodesShoppingCartPaypal.Models.Entities;
using OctopusCodesShoppingCartPaypal.Models.Repositories;

namespace OctopusCodesShoppingCartPaypal.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EntityContext _context;
        public UnitOfWork(EntityContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepositoryBase<T> Repository<T>() where T : class
        {
            return new RepositoryBase<T>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
