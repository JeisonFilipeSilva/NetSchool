using Store.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.domain.Contracts.Repository
{
    public interface IUserRepository: IDisposable
    {
        User Get(string Username);
        User GetUserGuid(Guid IdUser);
        List<User> GetListUser(int skip, int take);
        void CreateUser(User user);
        void UpdateUser(User user);      

    }
}
