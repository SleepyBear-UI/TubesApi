using System.ComponentModel.DataAnnotations;
using TubesApi.Models;

namespace TubesApi.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string username { get; private set; }
        public string password { get; private set; }
        public List<PerusahaanModel> queuePerusahaan { get; set; }
        public List<PerusahaanModel> daftarPerusahaanVerified { get; set; }
    }
}
