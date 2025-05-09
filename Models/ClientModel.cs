// Models/Client.cs
namespace KonstruksiPerangkatLunak.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string? Nama { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        // Relasi ke proyek, forum, dll bisa ditambahkan nanti
    }
}

