// Data/ApplicationDbContext.cs
using TubesApi.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<PerusahaanModel> Perusahaans => Set<PerusahaanModel>();
    public DbSet<PelamarModel> Pelamars => Set<PelamarModel>();
    public DbSet<LowonganModel> Lowongans => Set<LowonganModel>();
    public DbSet<LowonganPelamarModel> Lamarans => Set<LowonganPelamarModel>();
    public DbSet<AdminModel> Admins => Set<AdminModel>();
    public DbSet<KaryawanPerusahaanModel> KaryawanPerusahaans => Set<KaryawanPerusahaanModel>();

    public object LowonganModel { get; internal set; }
}
