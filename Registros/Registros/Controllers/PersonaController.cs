using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registros.Data;
using Registros.Models;

namespace Registros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PersonaController(AppDbContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonaModel persona)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = persona.Id }, persona);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona == null) return NotFound();
            return Ok(persona);
        }
    }
}
