using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KonstruksiPerangkatLunak.Models;

namespace KonstruksiPerangkatLunak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LowonganController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LowonganController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLowongan()
        {
            var lowongans = await _context.Lowongans
                .ToListAsync();

            return Ok(lowongans);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LowonganModel lowongan)
        {
            _context.Lowongans.Add(lowongan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllLowongan), new { id = lowongan.Id }, lowongan);
        }

        [HttpGet("lowongan/{lowonganId}")]
        public async Task<IActionResult> GetByLowongan(int lowonganId)
        {
            var lowongan = await _context.Lowongans
                .Where(l => l.Id == lowonganId)
                .ToListAsync();

            return Ok(lowongan);
        }
    }
}
