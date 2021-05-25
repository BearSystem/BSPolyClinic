using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Infra.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        public Task<IdentityResult> CreateUser(User user, string senha)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetQuantityRegisteredUresrs()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetUserRole(User user)
        {
            throw new NotImplementedException();
        }

        public Task IncludeUserInRole(User user, string funcao)
        {
            throw new NotImplementedException();
        }

        public Task SignIn(User user, bool lembrar)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
