using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using BSPolyClinic.Domain.Entities.ViewModel;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Domain.ValueObjects;
using SecureIdentity.Password;
using System.Globalization;

namespace BSPolyClinic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotController : Controller
    {

        private readonly Context _context;
        private readonly IUser userRepository;

        public ChatbotController(Context context, IUser userRepository)
        {
            _context = context;
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("findUserByCpf/{cpf}")]
        public async Task<ActionResult<bool>> FindUserByCpf(string cpf)
        {
            var usuario = await userRepository.FindUserByCpf(cpf);

            if (usuario)
                return usuario;

            return NotFound();
        }

        [HttpGet]
        [Route("SearchQueriesByCpf/{cpf}")]
        public async Task<ActionResult<bool>> SearchQueriesByCpf(string cpf)
        {
            var usuario = await userRepository.FindUserByCpf(cpf);

            if (usuario)
                return usuario;

            return NotFound();
        }


        [HttpGet]
        [Route("NewUser/{cpf}/{nome}/{dataNascimento}/{email}/{telefone}")]
        public async Task<ActionResult<bool>> RegisterUserChatbot(string cpf, string name, string dataNascimento, string email, string telefone)
        {

            var nameUser = new Name(name, name);
            var documentUser = new Document(cpf);
            var emailUser = new Email(email);
            var cellPhone = new Phone(telefone, EPhoneType.Personal);

            var createUser = new User(nameUser, documentUser, emailUser, EUserType.Patient);

            createUser.UserName = email;
            createUser.Email = email;

            var date = DateTime.ParseExact(dataNascimento, "ddMMyyyy", CultureInfo.InvariantCulture);
            createUser.AlterUserBirthday(date);

            var password = PasswordGenerator.Generate(length: 10, includeSpecialChars: true);

            var usuario = await userRepository.CreateUser(createUser, password);

            if (usuario != null)
                return true;

            return NotFound();
        }
    }
}
