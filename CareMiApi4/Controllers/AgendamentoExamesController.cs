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
    public class AgendamentoExamesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AgendamentoExamesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AgendamentoExames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgendamentoExame>>> GetAgendamentoExames()
        {
            return await _context.AgendamentoExames.ToListAsync();
        }

        // GET: api/AgendamentoExames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AgendamentoExame>> GetAgendamentoExame(int id)
        {
            var agendamentoExame = await _context.AgendamentoExames.FindAsync(id);

            if (agendamentoExame == null)
            {
                return NotFound();
            }

            return agendamentoExame;
        }

        // PUT: api/AgendamentoExames/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamentoExame(int id, AgendamentoExame agendamentoExame)
        {
            if (id != agendamentoExame.CdAgendamento)
            {
                return BadRequest();
            }

            _context.Entry(agendamentoExame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendamentoExameExists(id))
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

        // POST: api/AgendamentoExames
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AgendamentoExame>> PostAgendamentoExame(AgendamentoExame agendamentoExame)
        {
            _context.AgendamentoExames.Add(agendamentoExame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgendamentoExame", new { id = agendamentoExame.CdAgendamento }, agendamentoExame);
        }

        // DELETE: api/AgendamentoExames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamentoExame(int id)
        {
            var agendamentoExame = await _context.AgendamentoExames.FindAsync(id);
            if (agendamentoExame == null)
            {
                return NotFound();
            }

            _context.AgendamentoExames.Remove(agendamentoExame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendamentoExameExists(int id)
        {
            return _context.AgendamentoExames.Any(e => e.CdAgendamento == id);
        }
    }
}
