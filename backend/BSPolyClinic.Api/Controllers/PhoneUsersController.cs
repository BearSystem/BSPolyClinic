using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra;

namespace BSPolyClinic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneUsersController : ControllerBase
    {
        private readonly Context _context;

        public PhoneUsersController(Context context)
        {
            _context = context;
        }

        // GET: api/PhoneUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoneUser>>> GetPhoneUsers()
        {
            return await _context.PhoneUsers.ToListAsync();
        }

        // GET: api/PhoneUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneUser>> GetPhoneUser(int id)
        {
            var phoneUser = await _context.PhoneUsers.FindAsync(id);

            if (phoneUser == null)
            {
                return NotFound();
            }

            return phoneUser;
        }

        // PUT: api/PhoneUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoneUser(int id, PhoneUser phoneUser)
        {
            if (id != phoneUser.PhoneUserId)
            {
                return BadRequest();
            }

            _context.Entry(phoneUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PhoneUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhoneUser>> PostPhoneUser(PhoneUser phoneUser)
        {
            _context.PhoneUsers.Add(phoneUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhoneUser", new { id = phoneUser.PhoneUserId }, phoneUser);
        }

        // DELETE: api/PhoneUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoneUser(int id)
        {
            var phoneUser = await _context.PhoneUsers.FindAsync(id);
            if (phoneUser == null)
            {
                return NotFound();
            }

            _context.PhoneUsers.Remove(phoneUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhoneUserExists(int id)
        {
            return _context.PhoneUsers.Any(e => e.PhoneUserId == id);
        }
    }
}
