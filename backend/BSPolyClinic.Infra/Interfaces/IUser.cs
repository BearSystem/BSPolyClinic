using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Domain.Entities.ViewModel;
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
        Task<bool> CreateUserByChat(User user, string password);

        Task IncludeUserInRole(User user, string funcao);

        Task SignIn(User user, bool lembrar);

        Task<User> FindUserById(string id);
        Task<bool> FindUserByCpf(string Cpf);

        Task<User> GetUserByEmail(string email);

        Task<IList<string>> GetUserRole(User user);

        Task UpdateUser(User user);
    }
}
