// Models/Client.cs
namespace TubesApi.Models
{
    public class PerusahaanModel
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string namaPerusahaan { get; set; }
        public string nomorPerusahaan { get; set; }
        public bool IsVerified { get; set; } = false;
        public static List<PelamarModel> daftarKaryawan { get; set; } = new List<PelamarModel>();
        public static List<LowonganModel> daftarLowongan { get; set; } = new List<LowonganModel>();

    }
}

