using System.ComponentModel.DataAnnotations;
using KonstruksiPerangkatLunak.Models;

namespace KonstruksiPerangkatLunak.Models
{
    public class Lamaran
    {
        public int Id { get; set; }

        public int ApplicantId { get; set; }
        public ApplicantModel Applicant { get; set; }

        public int LowonganId { get; set; }
        public LowonganModel Lowongan { get; set; }

        public DateTime TanggalLamar { get; set; } = DateTime.Now;
    }
}
