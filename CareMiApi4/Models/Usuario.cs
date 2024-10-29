using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm4_usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string NmUsuario { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtNascimento { get; set; }

        [Required]
        [StringLength(15)]
        public string NrCpf { get; set; }

        [Required]
        [StringLength(15)]
        public string NrRg { get; set; }

        [StringLength(50)]
        public string DsNacionalidade { get; set; }

        [StringLength(15)]
        public string NrTelefone { get; set; }
        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtCadastro { get; set; }

        [StringLength(100)]
        public string DsEstadoCivil { get; set; }

        [StringLength(100)]
        public string DsProfissao { get; set; }

        [Required]
        public int FgAtivo { get; set; }
        public Login? Login { get; set; }
        public Paciente? Paciente { get; set; }


        public Usuario()
        {
        }


        public Usuario(int cdUsuario, string nmUsuario, DateTime dtNascimento, string nrCpf, string nrRg,
                       string dsNacionalidade, string nrTelefone, DateTime dtCadastro, string dsEstadoCivil,
                       string dsProfissao, int fgAtivo)
        {
            CdUsuario = cdUsuario;
            NmUsuario = nmUsuario;
            DtNascimento = dtNascimento;
            NrCpf = nrCpf;
            NrRg = nrRg;
            DsNacionalidade = dsNacionalidade;
            NrTelefone = nrTelefone;
            DtCadastro = dtCadastro;
            DsEstadoCivil = dsEstadoCivil;
            DsProfissao = dsProfissao;
            FgAtivo = fgAtivo;
        }
    }

}