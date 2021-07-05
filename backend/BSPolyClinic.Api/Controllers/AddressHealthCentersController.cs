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
    public class AddressHealthCentersController : ControllerBase
    {
        private readonly Context _context;

        public AddressHealthCentersController(Context context)
        {
            _context = context;
        }

        // GET: api/AddressHealthCenters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressHealthCenter>>> GetAddressHealthCenters()
        {
            return await _context.AddressHealthCenters.ToListAsync();
        }

        // GET: api/AddressHealthCenters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddressHealthCenter>> GetAddressHealthCenter(int id)
        {
            var addressHealthCenter = await _context.AddressHealthCenters.FindAsync(id);

            if (addressHealthCenter == null)
            {
                return NotFound();
            }

            return addressHealthCenter;
        }

        // PUT: api/AddressHealthCenters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddressHealthCenter(int id, AddressHealthCenter addressHealthCenter)
        {
            if (id != addressHealthCenter.AddressHealthCenterId)
            {
                return BadRequest();
            }

            _context.Entry(addressHealthCenter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressHealthCenterExists(id))
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

        // POST: api/AddressHealthCenters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AddressHealthCenter>> PostAddressHealthCenter(AddressHealthCenter addressHealthCenter)
        {
            _context.AddressHealthCenters.Add(addressHealthCenter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddressHealthCenter", new { id = addressHealthCenter.AddressHealthCenterId }, addressHealthCenter);
        }

        // DELETE: api/AddressHealthCenters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddressHealthCenter(int id)
        {
            var addressHealthCenter = await _context.AddressHealthCenters.FindAsync(id);
            if (addressHealthCenter == null)
            {
                return NotFound();
            }

            _context.AddressHealthCenters.Remove(addressHealthCenter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressHealthCenterExists(int id)
        {
            return _context.AddressHealthCenters.Any(e => e.AddressHealthCenterId == id);
        }
    }
}
