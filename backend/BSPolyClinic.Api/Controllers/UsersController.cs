using BSPolyClinic.Api.Security;
using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Entities.ViewModel;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Infra.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IUser userRepository;

        public UsersController(IUser userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UpdateUserViewModel>> GetUser(Guid id)
        {
            var User = await userRepository.findById(id);

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

        [HttpPost("SalvarFoto")]
        public async Task<ActionResult> SalvarFoto()
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

        [HttpPost("RegistrarUser")]
        public async Task<ActionResult> RegistrarUser(SignUpViewModel model, EUserType type)
        {
            if (ModelState.IsValid)
            {
                IdentityResult newUser;
                string userRole = "";




                if (await userRepository.GetQuantityRegisteredUresrs() == 0)
                {
                    userRole = "Administrador";
                }
                else
                {
                    switch (type)
                    {
                        case EUserType.Administrator:
                            userRole = "Administrador";
                            break;
                        case EUserType.Manager:
                            userRole = "Manager";
                            break;
                        case EUserType.Doctor:
                            userRole = "Doctor";
                            break;
                        case EUserType.Nurse:
                            userRole = "Nurse";
                            break;
                        case EUserType.Attendant:
                            userRole = "Attendant";
                            break;
                        default:
                            userRole = "Patient";
                            break;

                    }
                }

                newUser = await userRepository.CreateUser(model.User, model.Password);

                if (newUser.Succeeded)
                {
                    await userRepository.IncludeUserInRole(model.User, userRole);
                    var token = TokenService.GerarToken(model.User, userRole);
                    await userRepository.SignIn(model.User, false);

                    return Ok(new
                    {
                        emailUserLogado = model.User.Email,
                        UserId = model.User.Id,
                        tokenUserLogado = token
                    });
                }

                else
                {
                    return BadRequest(model);
                }
            }

            return BadRequest(model);

        }

        [HttpPost("LogarUser")]
        public async Task<ActionResult> LogarUser(SignInViewModel model)
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

        [HttpGet("RetornarFotoUser/{UserId}")]
        public async Task<dynamic> RetornarFotoUser(string UserId)
        {
            User User = await userRepository.findUserById(UserId);

            return new { imagem = User.Foto };
        }

        [HttpPut("AtualizarUser")]
        public async Task<ActionResult> AtualizarUser(UpdateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User User = await userRepository.findUserById(model.User.Id);
                
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
