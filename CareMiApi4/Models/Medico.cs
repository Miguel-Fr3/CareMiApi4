using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm_medico")]
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdMedico { get; set; }

        [Required]
        [StringLength(100)]
        public string NmMedico { get; set; }

        [StringLength(200)]
        public string DsEspecializacao { get; set; }

        [Required]
        [StringLength(15)]
        public string DsCrm { get; set; }

        [Required]
        [StringLength(100)]
        public string DsEmail { get; set; }

        [Column(TypeName = "NUMBER(9)")]
        public int NrCelular { get; set; }

        public ICollection<AgendamentoExame>? AgendamentoExame { get; set; }

        public Medico()
        {
        }

        public Medico(int cdMedico, string nmMedico, string dsEspecializacao, string dsCrm, string dsEmail, int nrCelular)
        {
            CdMedico = cdMedico;
            NmMedico = nmMedico;
            DsEspecializacao = dsEspecializacao;
            DsCrm = dsCrm;
            DsEmail = dsEmail;
            NrCelular = nrCelular;
        }
    }
}