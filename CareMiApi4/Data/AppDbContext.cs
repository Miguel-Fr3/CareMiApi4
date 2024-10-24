using CareMiApi4.Models;
using Microsoft.EntityFrameworkCore;

namespace CareMiApi4.Data
{
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<ResultadoExame> ResultadoExames { get; set; }
    public DbSet<PlanoSaude> PlanosSaude { get; set; }
    public DbSet<PacientePlanoSaude> PacientesPlanosSaude { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Login> Logins { get; set; }
    public DbSet<Exame> Exames { get; set; }
    public DbSet<Carteirinha> Carteirinhas { get; set; }
    public DbSet<AgendamentoExame> AgendamentoExames { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PacientePlanoSaude>()
            .HasKey(pp => new { pp.PacienteId, pp.PlanoSaudeId });

        modelBuilder.Entity<PacientePlanoSaude>()
            .HasOne(pp => pp.Paciente)
            .WithMany()
            .HasForeignKey(pp => pp.PacienteId);

        modelBuilder.Entity<PacientePlanoSaude>()
            .HasOne(pp => pp.PlanoSaude)
            .WithMany()
            .HasForeignKey(pp => pp.PlanoSaudeId);


        base.OnModelCreating(modelBuilder);
    }


}
}