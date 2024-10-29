using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm4_login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdLogin { get; set; }

        [Required]
        [StringLength(15)]
        public string NrCpf { get; set; }

        [Required]
        [StringLength(100)]
        public string DsSenha { get; set; }

        [Required]
        public int FgAtivo { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        public Login()
        {
        }

        public Login(int cdLogin, string nrCpf, string dsSenha, int fgAtivo, int usuarioId)
        {
            CdLogin = cdLogin;
            NrCpf = nrCpf;
            DsSenha = dsSenha;
            FgAtivo = fgAtivo;
            UsuarioId = usuarioId;
        }
    }
}