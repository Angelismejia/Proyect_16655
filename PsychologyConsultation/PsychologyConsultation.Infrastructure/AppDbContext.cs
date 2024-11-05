using Microsoft.EntityFrameworkCore;
using PsychologyConsultation.Domain.Entities;

public class AppDbContext : DbContext
{
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Consulta> Consultas { get; set; }
    public DbSet<Tratamiento> Tratamientos { get; set; }
    public DbSet<SesionSeguimiento> SesionesSeguimiento { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
