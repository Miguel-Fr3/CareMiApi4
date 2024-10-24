using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm_exame")]
    public class Exame
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdExame { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DtExame { get; set; }
        [Required]
        [StringLength(50)]
        public string DsExame { get; set; }

        [ForeignKey("AgendamentoExameId")]
        public int? AgendamentoExameId { get; set; }

        public AgendamentoExame? AgendamentoExame { get; set; }
        public ResultadoExame? ResultadoExame { get; set; }
        public Exame() { }
        public Exame(string dsExame, DateTime dtExame, int agendamentoExameId)
        {
            DsExame = dsExame;
            DtExame = dtExame;
            AgendamentoExameId = agendamentoExameId;
        }
    }
}