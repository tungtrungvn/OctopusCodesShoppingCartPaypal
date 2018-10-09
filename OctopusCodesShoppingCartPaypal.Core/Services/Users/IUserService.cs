using System.Linq;
using OctopusCodesShoppingCartPaypal.Core.Models.Users;
using OctopusCodesShoppingCartPaypal.Models.Entities;

namespace OctopusCodesShoppingCartPaypal.Core.Services.Users
{ 
    public interface IUserService : IBaseService<Account>
    {
        Account FindByName(string userName);
        Account FindById(int id);
        IQueryable<Account> GetAll();
        void Insert(UserViewModel user);
        void Insert(RegisterViewModel model);
        void Update(UserViewModel user);
        void Update(UserInfoViewModel user);
        void Delete(int id);
    }
}
