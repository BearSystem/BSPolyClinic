using BSPolyClinic.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Interfaces
{
    public interface IUser : IGeneric<User>
    {
        Task<int> GetQuantityRegisteredUresrs();

        Task<IdentityResult> CreateUser(User user, string senha);

        Task IncludeUserInRole(User user, string funcao);

        Task SignIn(User user, bool lembrar);

        Task<User> GetUserByEmail(string email);

        Task<IList<string>> GetUserRole(User user);

        Task UpdateUser(User user);
    }
}
