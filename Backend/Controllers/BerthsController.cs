using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BerthsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BerthsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/berths
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Berth>>> GetBerths()
        {
            return await _context.Berths.ToListAsync();
        }

        // GET: api/berths/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Berth>> GetBerth(int id)
        {
            var berth = await _context.Berths.FindAsync(id);

            if (berth == null)
            {
                return NotFound();
            }

            return berth;
        }

        // POST: api/berths
        [HttpPost]
        public async Task<ActionResult<Berth>> CreateBerth(Berth berth)
        {
            _context.Berths.Add(berth);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBerth), new { id = berth.Id }, berth);
        }

        // PUT: api/berths/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBerth(int id, Berth berth)
        {
            if (id != berth.Id)
            {
                return BadRequest();
            }

            _context.Entry(berth).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BerthExists(id))
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

        // DELETE: api/berths/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBerth(int id)
        {
            var berth = await _context.Berths.FindAsync(id);
            if (berth == null)
            {
                return NotFound();
            }

            _context.Berths.Remove(berth);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BerthExists(int id)
        {
            return _context.Berths.Any(e => e.Id == id);
        }
    }
}