using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm_plano_saude")]
    public class PlanoSaude
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdPlanoSaude { get; set; }

        [Required]
        [StringLength(100)]
        public string DsRazaoSocial { get; set; }

        [Required]
        [StringLength(100)]
        public string NmFantasia { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(14)")]
        public int NrCnpj { get; set; }

        [Required]
        [StringLength(100)]
        public string NmContato { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(8)")]
        public int NrTelefone { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtCadastro { get; set; }

        [Required]
        public int FgAtivo { get; set; }

        public ICollection<PacientePlanoSaude>? PacientePlanosSaude { get; set; }
        public PlanoSaude()
        {
        }

        public PlanoSaude(int cdPlanoSaude, string dsRazaoSocial, string nmFantasia, int nrCnpj, string nmContato, int nrTelefone, DateTime dtCadastro, int fgAtivo)
        {
            CdPlanoSaude = cdPlanoSaude;
            DsRazaoSocial = dsRazaoSocial;
            NmFantasia = nmFantasia;
            NrCnpj = nrCnpj;
            NmContato = nmContato;
            NrTelefone = nrTelefone;
            DtCadastro = dtCadastro;
            FgAtivo = fgAtivo;
        }
    }
}