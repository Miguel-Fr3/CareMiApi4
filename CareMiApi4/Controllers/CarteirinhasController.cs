using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CareMiApi4.Data;
using CareMiApi4.Models;

namespace CareMiApi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteirinhasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarteirinhasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Carteirinhas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carteirinha>>> GetCarteirinhas()
        {
            return await _context.Carteirinhas.ToListAsync();
        }

        // GET: api/Carteirinhas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carteirinha>> GetCarteirinha(int id)
        {
            var carteirinha = await _context.Carteirinhas.FindAsync(id);

            if (carteirinha == null)
            {
                return NotFound();
            }

            return carteirinha;
        }

        // PUT: api/Carteirinhas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarteirinha(int id, Carteirinha carteirinha)
        {
            if (id != carteirinha.CdCarteirinha)
            {
                return BadRequest();
            }

            _context.Entry(carteirinha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarteirinhaExists(id))
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

        // POST: api/Carteirinhas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carteirinha>> PostCarteirinha(Carteirinha carteirinha)
        {
            _context.Carteirinhas.Add(carteirinha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarteirinha", new { id = carteirinha.CdCarteirinha }, carteirinha);
        }

        // DELETE: api/Carteirinhas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarteirinha(int id)
        {
            var carteirinha = await _context.Carteirinhas.FindAsync(id);
            if (carteirinha == null)
            {
                return NotFound();
            }

            _context.Carteirinhas.Remove(carteirinha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarteirinhaExists(int id)
        {
            return _context.Carteirinhas.Any(e => e.CdCarteirinha == id);
        }
    }
}
