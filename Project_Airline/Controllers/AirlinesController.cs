using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Airline.Data;
using Project_Airline.Models;

namespace Project_Airline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private readonly Project_AirlineContext _context;

        public AirlinesController(Project_AirlineContext context)
        {
            _context = context;
        }

        // GET: api/Airlines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airline>>> GetAirline()
        {
            return await _context.Airline.ToListAsync();
        }

        // GET: api/Airlines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Airline>> GetAirline(int id)
        {
            var airline = await _context.Airline.FindAsync(id);

            if (airline == null)
            {
                return NotFound();
            }

            return airline;
        }

        // PUT: api/Airlines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAirline(int id, Airline airline)
        {
            if (id != airline.Id)
            {
                return BadRequest();
            }

            _context.Entry(airline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirlineExists(id))
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

        // POST: api/Airlines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Airline>> PostAirline(Airline airline)
        {
            _context.Airline.Add(airline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAirline", new { id = airline.Id }, airline);
        }

        // DELETE: api/Airlines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Airline>> DeleteAirline(int id)
        {
            var airline = await _context.Airline.FindAsync(id);
            if (airline == null)
            {
                return NotFound();
            }

            _context.Airline.Remove(airline);
            await _context.SaveChangesAsync();

            return airline;
        }

        private bool AirlineExists(int id)
        {
            return _context.Airline.Any(e => e.Id == id);
        }
    }
}
