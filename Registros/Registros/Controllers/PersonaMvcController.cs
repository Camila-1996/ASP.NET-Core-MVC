using Microsoft.AspNetCore.Mvc;
using Registros.Data;
using Registros.Models;

namespace Registros.Controllers
{
    public class PersonaMvcController : Controller
    {
        
        private readonly AppDbContext _context;
        public PersonaMvcController(AppDbContext context) => _context = context;

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(PersonaModel persona)
        {
            if (!ModelState.IsValid) return View(persona);

            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
