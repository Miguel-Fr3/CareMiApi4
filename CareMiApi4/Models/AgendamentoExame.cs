using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CareMiApi4.Models
{

    [Table("t_cm_agendamento_exame")]
    public class AgendamentoExame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdAgendamento { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(11)")]
        public int NrCPF { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(15)")]
        public int NrRG { get; set; }

        [Required]
        [StringLength(100)]
        public string DsNome { get; set; }

        [Required]
        [StringLength(250)]
        public string DsObservacao { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtAgendamento { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtEnvio { get; set; }

        [Required]
        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }

        [ForeignKey("PacienteId")]
        public int? PacienteId { get; set; }

        public Paciente? Paciente { get; set; }

        public ICollection<Exame>? Exame { get; set; }

        public AgendamentoExame()
        {
        }

        public AgendamentoExame(int nrCPF, int nrRG, string dsNome, string dsObservacao, DateTime dtAgendamento, DateTime dtEnvio, int medicoId, int pacienteId)
        {
            NrCPF = nrCPF;
            NrRG = nrRG;
            DsNome = dsNome;
            DsObservacao = dsObservacao;
            DtAgendamento = dtAgendamento;
            DtEnvio = dtEnvio;
            MedicoId = medicoId;
            PacienteId = pacienteId;
        }
    }
}