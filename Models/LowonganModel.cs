// Models/Lowongan.cs

namespace KonstruksiPerangkatLunak.Models
{
    public class LowonganModel
    {
        public int Id { get; set; }
        public string? Judul { get; set; }
        public string? Deskripsi { get; set; }
        public string? Kategori { get; set; }
        public DateTime TanggalPosting { get; set; } = DateTime.Now;
        public string? DiperuntukkanUntuk { get; set; } // contoh: "Freelance" / "Client"
    }
}
