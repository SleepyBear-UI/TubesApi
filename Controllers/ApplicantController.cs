using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KonstruksiPerangkatLunak.Models;

namespace KonstruksiPerangkatLunak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicantController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApplicantController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllApplicant()
        {
            var applicants = await _context.Applicants
                .ToListAsync();
            return Ok(applicants);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApplicantModel applicant)
        {
            _context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllApplicant), new { id = applicant.Id }, applicant);
        }

        [HttpGet("applicant/{applicantId}")]
        public async Task<IActionResult> GetByClients(int applicantId)
        {
            var applicants = await _context.Applicants
                .Where(l => l.Id == applicantId)
                .ToListAsync();

            return Ok(applicants);
        }
    }
}
