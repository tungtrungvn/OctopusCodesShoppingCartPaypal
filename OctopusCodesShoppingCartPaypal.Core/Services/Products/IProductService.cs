﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OctopusCodesShoppingCartPaypal.Core.Models.Products;
using OctopusCodesShoppingCartPaypal.Models.Entities;

namespace OctopusCodesShoppingCartPaypal.Core.Services.Products
{
    public interface IProductService : IBaseService<Product>
    {
        IQueryable<Product> GetAll();
        Product FindById(int id);
        void Insert(ProductViewModel model);
        void Update(ProductViewModel model);
        void Delete(int id);
    }
}
