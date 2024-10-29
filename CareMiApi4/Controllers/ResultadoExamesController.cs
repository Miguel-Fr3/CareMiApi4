using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CareMiApi4.Data;
using CareMiApi4.Models;
using Microsoft.AspNetCore.Authorization;

namespace CareMiApi4.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoExamesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ResultadoExamesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ResultadoExames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResultadoExame>>> GetResultadoExames()
        {
            return await _context.ResultadoExames.ToListAsync();
        }

        // GET: api/ResultadoExames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoExame>> GetResultadoExame(int id)
        {
            var resultadoExame = await _context.ResultadoExames.FindAsync(id);

            if (resultadoExame == null)
            {
                return NotFound();
            }

            return resultadoExame;
        }

        // PUT: api/ResultadoExames/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResultadoExame(int id, ResultadoExame resultadoExame)
        {
            if (id != resultadoExame.CdResultado)
            {
                return BadRequest();
            }

            _context.Entry(resultadoExame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultadoExameExists(id))
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

        // POST: api/ResultadoExames
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ResultadoExame>> PostResultadoExame(ResultadoExame resultadoExame)
        {
            _context.ResultadoExames.Add(resultadoExame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResultadoExame", new { id = resultadoExame.CdResultado }, resultadoExame);
        }

        // DELETE: api/ResultadoExames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResultadoExame(int id)
        {
            var resultadoExame = await _context.ResultadoExames.FindAsync(id);
            if (resultadoExame == null)
            {
                return NotFound();
            }

            _context.ResultadoExames.Remove(resultadoExame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResultadoExameExists(int id)
        {
            return _context.ResultadoExames.Any(e => e.CdResultado == id);
        }
    }
}
