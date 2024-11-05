using Microsoft.AspNetCore.Mvc;
using PsychologyConsultation.Domain.Entities;
using PsychologyConsultation.Infrastructure;

namespace PsychologyConsultation.Web.Controllers
{
    public class PacientesController : Controller
    {
        private readonly AppDbContext _context;

        public PacientesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pacientes = _context.Pacientes.ToList();
            return View(pacientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // Agrega los métodos Edit y Delete de manera similar
    }
}
