using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KonstruksiPerangkatLunak.Models;

namespace KonstruksiPerangkatLunak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LamaranController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LamaranController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lamarans = await _context.Lamarans
                .Include(l => l.Applicant)
                .Include(l => l.Lowongan)
                .ToListAsync();

            return Ok(lamarans);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lamaran lamaran)
        {
            _context.Lamarans.Add(lamaran);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = lamaran.Id }, lamaran);
        }

        [HttpGet("applicant/{applicantId}")]
        public async Task<IActionResult> GetByApplicant(int applicantId)
        {
            var lamarans = await _context.Lamarans
                .Where(l => l.ApplicantId == applicantId)
                .Include(l => l.Lowongan)
                .ToListAsync();

            return Ok(lamarans);
        }

    }
}
