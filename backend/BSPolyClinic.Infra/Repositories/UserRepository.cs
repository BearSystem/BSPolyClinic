using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Infra.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        private readonly Context context;
        private readonly UserManager<User> usersManager;
        private readonly SignInManager<User> loginManager;

        public UserRepository(Context context, UserManager<User> usersManager, SignInManager<User> loginManager) : base(context)
        {
            this.context = context;
            this.usersManager = usersManager;
            this.loginManager = loginManager;
        }

        public async Task<IdentityResult> CreateUser(User user, string senha)
        {
            try
            {
                var newUser = await usersManager.CreateAsync(user, senha);

                switch (user.UserType)
                {
                    case EUserType.Administrator:
                        var administrator = new Administrator(user.Id);
                        administrator.AddCreatedDate();
                        administrator.AddUpdatedDate();

                        context.Administrators.Add(administrator);
                        break;
                    case EUserType.Manager:
                        var manager = new Manager(user.Id);
                        manager.AddCreatedDate();
                        manager.AddUpdatedDate();

                        context.Managers.Add(manager);
                        break;
                    case EUserType.Doctor:
                        var doctor = new Doctor(user.Id);
                        doctor.AddCreatedDate();
                        doctor.AddUpdatedDate();

                        context.Doctors.Add(doctor);
                        break;
                    case EUserType.Nurse:
                        var nurse = new Nurse(user.Id);
                        nurse.AddCreatedDate();
                        nurse.AddUpdatedDate();

                        context.Nurses.Add(nurse);
                        break;
                    case EUserType.Attendant:
                        var attendant = new Attendant(user.Id);
                        attendant.AddCreatedDate();
                        attendant.AddUpdatedDate();

                        context.Attendants.Add(attendant);
                        break;
                    default:
                        var patient = new Patient(user.Id);
                        patient.AddCreatedDate();
                        patient.AddUpdatedDate();

                        context.Patients.Add(patient);
                        break;
                }
                context.SaveChanges();

                return newUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> findUserById(string id)
        {
            try
            {
                return await usersManager.FindByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> GetQuantityRegisteredUresrs()
        {
            try
            {
                return await context.Users.CountAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserByEmail(string email)
        {
            try
            {
                return await usersManager.FindByEmailAsync(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<string>> GetUserRole(User user)
        {
            try
            {
                return await usersManager.GetRolesAsync(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task IncludeUserInRole(User user, string funcao)
        {
            try
            {
                await usersManager.AddToRoleAsync(user, funcao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SignIn(User user, bool lembrar)
        {
            try
            {
                await loginManager.SignInAsync(user, lembrar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateUser(User user)
        {
            try
            {
                await usersManager.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
