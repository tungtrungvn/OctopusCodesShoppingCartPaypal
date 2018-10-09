using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OctopusCodesShoppingCartPaypal.Core.Models;
using OctopusCodesShoppingCartPaypal.Models.Entities;

namespace OctopusCodesShoppingCartPaypal.Core.Services.Categories
{
    public interface ICategoryService: IBaseService<Category>
    {
        IQueryable<Category> GetAll();
        Category FindById(int id);
        void Insert(Category entity);
        void Update(Category entity);
        void Delete(int id);
    }
}
