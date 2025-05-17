using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TubesApi.Models;

namespace TubesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllKaryawan()
        {
            var admins = await _context.KaryawanPerusahaans
                .ToListAsync();

            return Ok(admins);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdminModel admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllKaryawan), new { id = admin.Id }, admin);
        }

        [HttpGet("admin/{adminId}")]
        public async Task<IActionResult> GetByLowongan(int adminId)
        {
            var admins = await _context.Admins
                .Where(l => l.Id == adminId)
                .ToListAsync();

            return Ok(admins);
        }
    }
}
