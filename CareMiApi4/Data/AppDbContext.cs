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
            modelBuilder.Entity<ResultadoExame>().HasData(
        new ResultadoExame
        {
            CdResultado = 1,
            DsResultado = "Normal",
            DsObservacoes = "Tudo dentro dos parâmetros",
            VrResultado = (float)120.5m,
            NrGlobulosVermelhos = 4500,
            NrGlobulosBrancos = 6000,
            NrPlaquetas = 250000,
            NrHemoglobinaGlicada = 5,
            NrCreatinina = 1,
            NrColesterolTotal = 180,
            NrColesterolHDL = 60,
            NrColesterolLDL = 100,
            NrTriglicerides = 140,
            NrHormonioTireostimulanteTSH = 2
        },
        new ResultadoExame
        {
            CdResultado = 2,
            DsResultado = "Alto",
            DsObservacoes = "Colesterol elevado",
            VrResultado = (float)220.8m,
            NrGlobulosVermelhos = 4700,
            NrGlobulosBrancos = 6100,
            NrPlaquetas = 255000,
            NrHemoglobinaGlicada = 6,
            NrCreatinina = (float)1.2m,
            NrColesterolTotal = 240,
            NrColesterolHDL = 50,
            NrColesterolLDL = 160,
            NrTriglicerides = 200,
            NrHormonioTireostimulanteTSH = 3
        },
        new ResultadoExame
        {
            CdResultado = 3,
            DsResultado = "Baixo",
            DsObservacoes = "Anemia detectada",
            VrResultado = (float)90.3m,
            NrGlobulosVermelhos = 3800,
            NrGlobulosBrancos = 5500,
            NrPlaquetas = 230000,
            NrHemoglobinaGlicada = 4,
            NrCreatinina = (float)0.8m,
            NrColesterolTotal = 150,
            NrColesterolHDL = 70,
            NrColesterolLDL = 80,
            NrTriglicerides = 130,
            NrHormonioTireostimulanteTSH = 1
        },
        new ResultadoExame
        {
            CdResultado = 4,
            DsResultado = "Pré-diabetes",
            DsObservacoes = "Nível elevado de glicose",
            VrResultado = (float)140.0m,
            NrGlobulosVermelhos = 4200,
            NrGlobulosBrancos = 5900,
            NrPlaquetas = 245000,
            NrHemoglobinaGlicada = 6,
            NrCreatinina = 1,
            NrColesterolTotal = 190,
            NrColesterolHDL = 55,
            NrColesterolLDL = 105,
            NrTriglicerides = 150,
            NrHormonioTireostimulanteTSH = 2
        },
        new ResultadoExame
        {
            CdResultado = 5,
            DsResultado = "Hipertensão",
            DsObservacoes = "Pressão arterial acima do normal",
            VrResultado = (float)160.0m,
            NrGlobulosVermelhos = 4600,
            NrGlobulosBrancos = 6000,
            NrPlaquetas = 260000,
            NrHemoglobinaGlicada = 5,
            NrCreatinina = (float)1.1m,
            NrColesterolTotal = 200,
            NrColesterolHDL = 65,
            NrColesterolLDL = 120,
            NrTriglicerides = 170,
            NrHormonioTireostimulanteTSH = 2
        },
        new ResultadoExame
        {
            CdResultado = 6,
            DsResultado = "Anemia leve",
            DsObservacoes = "Nível de hemoglobina abaixo do ideal",
            VrResultado = (float)85.0m,
            NrGlobulosVermelhos = 3500,
            NrGlobulosBrancos = 5600,
            NrPlaquetas = 235000,
            NrHemoglobinaGlicada = 4,
            NrCreatinina = (float)0.9m,
            NrColesterolTotal = 155,
            NrColesterolHDL = 60,
            NrColesterolLDL = 75,
            NrTriglicerides = 125,
            NrHormonioTireostimulanteTSH = 1
        },
        new ResultadoExame
        {
            CdResultado = 7,
            DsResultado = "Diabetes",
            DsObservacoes = "Glicose elevada",
            VrResultado = (float)240.0m,
            NrGlobulosVermelhos = 4400,
            NrGlobulosBrancos = 6000,
            NrPlaquetas = 248000,
            NrHemoglobinaGlicada = 8,
            NrCreatinina = (float)1.3m,
            NrColesterolTotal = 250,
            NrColesterolHDL = 40,
            NrColesterolLDL = 170,
            NrTriglicerides = 220,
            NrHormonioTireostimulanteTSH = 3
        },
        new ResultadoExame
        {
            CdResultado = 8,
            DsResultado = "Hipotireoidismo",
            DsObservacoes = "Nível elevado de TSH",
            VrResultado = (float)105.3m,
            NrGlobulosVermelhos = 4300,
            NrGlobulosBrancos = 5700,
            NrPlaquetas = 240000,
            NrHemoglobinaGlicada = 5,
            NrCreatinina = (float)1.0m,
            NrColesterolTotal = 210,
            NrColesterolHDL = 58,
            NrColesterolLDL = 110,
            NrTriglicerides = 160,
            NrHormonioTireostimulanteTSH = 5
        },
        new ResultadoExame
        {
            CdResultado = 9,
            DsResultado = "Colesterol alto",
            DsObservacoes = "Recomenda-se dieta para redução de colesterol",
            VrResultado = (float)195.4m,
            NrGlobulosVermelhos = 4500,
            NrGlobulosBrancos = 6100,
            NrPlaquetas = 245000,
            NrHemoglobinaGlicada = 5,
            NrCreatinina = (float)1.1m,
            NrColesterolTotal = 230,
            NrColesterolHDL = 50,
            NrColesterolLDL = 150,
            NrTriglicerides = 190,
            NrHormonioTireostimulanteTSH = 2
        },
        new ResultadoExame
        {
            CdResultado = 10,
            DsResultado = "Anemia severa",
            DsObservacoes = "Necessário acompanhamento médico urgente",
            VrResultado = (float)70.2m,
            NrGlobulosVermelhos = 3000,
            NrGlobulosBrancos = 5200,
            NrPlaquetas = 220000,
            NrHemoglobinaGlicada = 3,
            NrCreatinina = (float)0.7m,
            NrColesterolTotal = 140,
            NrColesterolHDL = 65,
            NrColesterolLDL = 60,
            NrTriglicerides = 110,
            NrHormonioTireostimulanteTSH = 1
        }

    );



            base.OnModelCreating(modelBuilder);
    }


}
}