using System.ComponentModel.DataAnnotations;
using TubesApi.Models;

namespace TubesApi.Models
{
    public class LowonganPelamarModel
    {
        public int Id { get; set; }
        public int PelamarId { get; set; }
        public PelamarModel Pelamar { get; set; }

        public int PerusahaanId { get; set; }
        public PerusahaanModel Perusahaan { get; set; }

        public int LowonganId { get; set; }
        public LowonganModel Lowongan { get; set; }
        public string state { get; set; }
    }
}
