// Data/ApplicationDbContext.cs
using KonstruksiPerangkatLunak.Models;
using Microsoft.EntityFrameworkCore;

    

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<ClientModel> Clients => Set<ClientModel>();
    public DbSet<ApplicantModel> Applicants => Set<ApplicantModel>();
    public DbSet<LowonganModel> Lowongans => Set<LowonganModel>();
    public DbSet<Lamaran> Lamarans => Set<Lamaran>();

    public object LowonganModel { get; internal set; }
}
