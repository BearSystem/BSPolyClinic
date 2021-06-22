using BSPolyClinic.Api.Security;
using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Domain.Entities.ViewModel;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Domain.ValueObjects;
using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace BSPolyClinic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Context _context;
        private readonly IUser userRepository;

        public UsersController(Context context, IUser userRepository)
        {
            _context = context;
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UpdateUserViewModel>> findUserById(Guid id)
        {
            var User = await userRepository.FindById(id);

            if (User == null)
            {
                return NotFound();
            }

            var model = new UpdateUserViewModel
            {
                User = User
            };

            return model;
        }

        [HttpPost("SaveFoto")]
        public async Task<ActionResult> SaveFoto()
        {
            var foto = Request.Form.Files[0];
            byte[] b;

            using (var openReadStream = foto.OpenReadStream())
            {
                using (var memoryStream = new MemoryStream())
                {
                    await openReadStream.CopyToAsync(memoryStream);
                    b = memoryStream.ToArray();
                }
            }

            return Ok(new
            {
                foto = b
            });
        }

        [HttpPost("SignUp")]
        public async Task<ActionResult> RegisterUser([FromBody]SignUpViewModel singUpUser)
        {
            if (ModelState.IsValid)
            {
                IdentityResult newUser;
                string userRole = "";


                if (await userRepository.GetQuantityRegisteredUresrs() == 0)
                {
                    singUpUser.TypeUser = EUserType.Administrator;
                    userRole = "ADMINISTRATOR";
                }
                else
                {
                    switch (singUpUser.TypeUser)
                    {
                        case EUserType.Administrator:
                            userRole = "ADMINISTRATOR";
                            break;
                        case EUserType.Manager:
                            userRole = "MANAGER";
                            break;
                        case EUserType.Doctor:
                            userRole = "DOCTOR";
                            break;
                        case EUserType.Nurse:
                            userRole = "NURSE";
                            break;
                        case EUserType.Attendant:
                            userRole = "Attendant";
                            break;
                        default:
                            userRole = "PATIENT";
                            break;

                    }
                }

                var nameUser = new Name(singUpUser.FirstName, singUpUser.LastName);
                var documentUser = new Document(singUpUser.Cpf);
                var emailUser = new Email(singUpUser.Email);

                var createUser = new User(nameUser, documentUser, emailUser, singUpUser.TypeUser);

                createUser.UserName = singUpUser.Email;
                createUser.Email = singUpUser.Email;
                createUser.PasswordHash = singUpUser.Password;
                createUser.Foto = singUpUser.Foto;
                createUser.Crm = singUpUser.Crm;


                newUser = await userRepository.CreateUser(createUser, singUpUser.Password);

                if (newUser.Succeeded)
                {
                    await userRepository.IncludeUserInRole(createUser, userRole);
                    var token = TokenService.GerarToken(createUser, userRole);
                    await userRepository.SignIn(createUser, false);

                    return Ok(new
                    {
                        emailUserLogado = createUser.Email,
                        UserId = createUser.Id,
                        tokenUserLogado = token
                    });
                }

                else
                {
                    return BadRequest(createUser);
                }
            }

            return BadRequest(singUpUser);

        }

        [HttpPost("SignIn")]
        public async Task<ActionResult> LoginUser(SignInViewModel model)
        {
            if (model == null)
                return NotFound("Usuário e / ou senhas inválidos");

            User User = await userRepository.GetUserByEmail(model.Email);

            if (User != null)
            {
                PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
                if (passwordHasher.VerifyHashedPassword(User, User.PasswordHash, model.Password) != PasswordVerificationResult.Failed)
                {
                    var userRole = await userRepository.GetUserRole(User);
                    var token = TokenService.GerarToken(User, userRole.First());
                    await userRepository.SignIn(User, false);

                    return Ok(new
                    {
                        emailUserLogado = User.Email,
                        UserId = User.Id,
                        tokenUserLogado = token
                    });
                }

                return NotFound("Usuário e / ou senha inválidos");
            }

            return NotFound("Usuário e / ou senha inválidos");
        }

        [HttpGet("ReturnPhotoUser/{UserId}")]
        public async Task<dynamic> ReturnPhotoUser(string UserId)
        {
            User User = await userRepository.FindUserById(UserId);

            return new { imagem = User.Foto };
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult> UpdateUser(UpdateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User User = await userRepository.FindUserById(model.User.Id);
                
                await userRepository.UpdateUser(User);

                return Ok(new
                {
                    mensagem = $"Usuário {User.Email} atualizado com sucesso"
                });
            }

            return BadRequest(model);
        }
    }
}
