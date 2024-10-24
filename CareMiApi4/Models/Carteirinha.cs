using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm_carteirinha")]
    public class Carteirinha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdCarteirinha { get; set; }

        [Required]
        [StringLength(100)]
        public string NmPaciente { get; set; }

        [Required]
        [StringLength(100)]
        public string NmPlanoSaude { get; set; }

        [Column(TypeName = "NUMBER(15)")]
        public decimal NrCns { get; set; }

        [StringLength(100)]
        public string NmEmpresa { get; set; }

        [StringLength(200)]
        public string DsCarencia { get; set; }

        [StringLength(200)]
        public string DsAcomodacao { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtNascimento { get; set; }

        [ForeignKey("PacienteCdPaciente")]
        public int? PacienteCdPaciente { get; set; }


        public Paciente? Paciente { get; set; }


        public Carteirinha()
        {
        }

        public Carteirinha(int cdCarteirinha, string nmPaciente, string nmPlanoSaude, decimal nrCns, string nmEmpresa, string dsCarencia, string dsAcomodacao, DateTime dtNascimento, int pacienteCdPaciente)
        {
            CdCarteirinha = cdCarteirinha;
            NmPaciente = nmPaciente;
            NmPlanoSaude = nmPlanoSaude;
            NrCns = nrCns;
            NmEmpresa = nmEmpresa;
            DsCarencia = dsCarencia;
            DsAcomodacao = dsAcomodacao;
            DtNascimento = dtNascimento;
            PacienteCdPaciente = pacienteCdPaciente;
        }
    }
}