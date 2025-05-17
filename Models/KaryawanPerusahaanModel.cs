using System.ComponentModel.DataAnnotations;
using TubesApi.Models;

namespace TubesApi.Models
{
    public class KaryawanPerusahaanModel
    {
        public int Id { get; set; }

        public int PelamarId { get; set; }
        public PelamarModel Pelamar { get; set; }

        public int PerusahaanId { get; set; }
        public PerusahaanModel Perusahaan { get; set; }
    }
}
