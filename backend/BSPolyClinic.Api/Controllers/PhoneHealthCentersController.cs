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
    public class PhoneHealthCentersController : ControllerBase
    {
        private readonly Context _context;

        public PhoneHealthCentersController(Context context)
        {
            _context = context;
        }

        // GET: api/PhoneHealthCenters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhoneHealthCenter>>> GetPhoneHealthCenters()
        {
            return await _context.PhoneHealthCenters.ToListAsync();
        }

        // GET: api/PhoneHealthCenters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhoneHealthCenter>> GetPhoneHealthCenter(int id)
        {
            var phoneHealthCenter = await _context.PhoneHealthCenters.FindAsync(id);

            if (phoneHealthCenter == null)
            {
                return NotFound();
            }

            return phoneHealthCenter;
        }

        // PUT: api/PhoneHealthCenters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoneHealthCenter(int id, PhoneHealthCenter phoneHealthCenter)
        {
            if (id != phoneHealthCenter.PhoneHealthCenterId)
            {
                return BadRequest();
            }

            _context.Entry(phoneHealthCenter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneHealthCenterExists(id))
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

        // POST: api/PhoneHealthCenters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhoneHealthCenter>> PostPhoneHealthCenter(PhoneHealthCenter phoneHealthCenter)
        {
            _context.PhoneHealthCenters.Add(phoneHealthCenter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhoneHealthCenter", new { id = phoneHealthCenter.PhoneHealthCenterId }, phoneHealthCenter);
        }

        // DELETE: api/PhoneHealthCenters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoneHealthCenter(int id)
        {
            var phoneHealthCenter = await _context.PhoneHealthCenters.FindAsync(id);
            if (phoneHealthCenter == null)
            {
                return NotFound();
            }

            _context.PhoneHealthCenters.Remove(phoneHealthCenter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhoneHealthCenterExists(int id)
        {
            return _context.PhoneHealthCenters.Any(e => e.PhoneHealthCenterId == id);
        }
    }
}
