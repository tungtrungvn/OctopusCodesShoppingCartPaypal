using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OctopusCodesShoppingCartPaypal.Core.Models;
using OctopusCodesShoppingCartPaypal.Models.Repositories;

namespace OctopusCodesShoppingCartPaypal.Core.Services
{
    public interface IBaseService<T> : IDisposable where T: class
    {
        IRepositoryBase<T> Repository { get; }
    }
}
