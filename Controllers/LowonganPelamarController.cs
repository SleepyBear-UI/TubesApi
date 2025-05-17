using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TubesApi.Models;

namespace TubesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LowonganPelamarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LowonganPelamarController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lamarans = await _context.Lamarans
                .Include(l => l.Pelamar)
                .Include(l => l.Lowongan)
                .ToListAsync();

            return Ok(lamarans);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LowonganPelamarModel lamaran)
        {
            _context.Lamarans.Add(lamaran);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = lamaran.Id }, lamaran);
        }

        [HttpGet("lamarans/{lamaransId}")]
        public async Task<IActionResult> GetByApplicant(int pelamarId)
        {
            var lamarans = await _context.Lamarans
                .Where(l => l.PelamarId == pelamarId)
                .Include(l => l.Lowongan)
                .ToListAsync();

            return Ok(lamarans);
        }

    }
}
