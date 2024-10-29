using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm4_paciente_plano_saude")]
    public class PacientePlanoSaude
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdPlanoPaciente { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(15)")]
        public int NrCarteira { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtInicio { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtFim { get; set; }

        [ForeignKey("PlanoSaudeId")]
        public int PlanoSaudeId { get; set; }

        public PlanoSaude PlanoSaude { get; set; }

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        public Paciente? Paciente { get; set; }

        public PacientePlanoSaude()
        {
        }

        public PacientePlanoSaude(int nrCarteira, DateTime dtInicio, DateTime dtFim, int planoSaudeId, int pacienteId)
        {
            NrCarteira = nrCarteira;
            DtInicio = dtInicio;
            DtFim = dtFim;
            PlanoSaudeId = planoSaudeId;
            PacienteId = pacienteId;
        }
    }
}