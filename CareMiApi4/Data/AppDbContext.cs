using CareMiApi4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

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
        public DbSet<Models.Login> Logins { get; set; }
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

            modelBuilder.Entity<Models.Login>().HasData(
                new Models.Login
                {
                    CdLogin = 1,
                    NrCpf = "Cpf123456",
                    DsSenha = "senha123456",
                    FgAtivo = 1,
                    UsuarioId = 1
                });
            modelBuilder.Entity<Models.Usuario>().HasData(
                new Models.Usuario
                {
                    CdUsuario = 1,
                    NmUsuario = "usuario Padrao",
                    DtNascimento = new DateTime(),
                    NrCpf = "Cpf123456",
                    NrRg = "rg123456",
                    DsNacionalidade = "BR",
                    NrTelefone = "telefone",
                    DtCadastro = new DateTime(),
                    DsEstadoCivil = "casado",
                    DsProfissao = "estagiario",
                    FgAtivo = 1,
                }
    );



            base.OnModelCreating(modelBuilder);
    }


}
}