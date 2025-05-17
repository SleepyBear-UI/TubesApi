using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TubesApi.Models;

namespace TubesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KaryawanPerusahaansController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KaryawanPerusahaansController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllKaryawan()
        {
            var karyawans = await _context.KaryawanPerusahaans
                .ToListAsync();

            return Ok(karyawans);
        }

        [HttpPost]
        public async Task<IActionResult> Create(KaryawanPerusahaanModel karayawan)
        {
            _context.KaryawanPerusahaans.Add(karayawan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllKaryawan), new { id = karayawan.Id }, karayawan);
        }

        [HttpGet("karyawan/{karyawanId}")]
        public async Task<IActionResult> GetByLowongan(int karyawanId)
        {
            var karyawan = await _context.KaryawanPerusahaans
                .Where(l => l.Id == karyawanId)
                .ToListAsync();

            return Ok(karyawan);
        }
    }
}
