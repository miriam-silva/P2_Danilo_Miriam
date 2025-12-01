using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisciplinasApi.Data;
using DisciplinasApi.Models;

namespace DisciplinasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DisciplinasController(AppDbContext context) => _context = context;

        // GET /api/disciplinas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disciplina>>> Get()
        {
            return await _context.Disciplinas.ToListAsync();
        }

        // GET /api/disciplinas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Disciplina>> Get(int id)
        {
            var disc = await _context.Disciplinas.FindAsync(id);
            if (disc == null) return NotFound();
            return disc;
        }

        // POST /api/disciplinas
        [HttpPost]
        public async Task<ActionResult<Disciplina>> Post(Disciplina disciplina)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _context.Disciplinas.Add(disciplina);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = disciplina.Id }, disciplina);
        }

        // PUT /api/disciplinas/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Disciplina disciplina)
        {
            if (id != disciplina.Id) return BadRequest("ID mismatch");
            _context.Entry(disciplina).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.Disciplinas.AnyAsync(d => d.Id == id)) return NotFound();
                throw;
            }
            return NoContent();
        }

        // DELETE /api/disciplinas/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var disc = await _context.Disciplinas.FindAsync(id);
            if (disc == null) return NotFound();
            _context.Disciplinas.Remove(disc);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
