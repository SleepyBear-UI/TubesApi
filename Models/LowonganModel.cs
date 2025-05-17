// Models/Lowongan.cs

namespace TubesApi.Models
{
    public class LowonganModel
    {
        public int Id { get; set; }
        public string namaPerusahaan { get; set; }
        public string title { get; set; }
        public string kriteria { get; set; }
        public string deskripsi { get; set; }
        public string lokasi { get; set; }
        public string gaji { get; set; }// contoh: "Freelance" / "Client"
    }
}
