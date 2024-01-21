using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShipsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShips()
        {
            return await _context.Ships.Include(s => s.Reservations).ToListAsync();
        }

        // GET: api/ships/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Ship>> GetShip(int id)
        {
            var ship = await _context.Ships.Include(s => s.Reservations)
                                           .FirstOrDefaultAsync(s => s.Id == id);

            if (ship == null)
            {
                return NotFound();
            }

            return ship;
        }

        // POST: api/ships
        [HttpPost]
        public async Task<ActionResult<Ship>> CreateShip(Ship ship)
        {
            _context.Ships.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetShip), new { id = ship.Id }, ship);
        }

        // PUT: api/ships/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShip(int id, Ship ship)
        {
            if (id != ship.Id)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipExists(id))
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

        // DELETE: api/ships/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip(int id)
        {
            var ship = await _context.Ships.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Ships.Remove(ship);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShipExists(int id)
        {
            return _context.Ships.Any(e => e.Id == id);
        }
    }
}