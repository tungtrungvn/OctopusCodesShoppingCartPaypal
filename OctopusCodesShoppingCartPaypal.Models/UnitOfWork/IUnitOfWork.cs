using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OctopusCodesShoppingCartPaypal.Models.Repositories;

namespace OctopusCodesShoppingCartPaypal.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable 
    {
        IRepositoryBase<T> Repository<T>() where T: class ;
        void Save();
    }
}
