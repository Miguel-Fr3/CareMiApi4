using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareMiApi4.Models
{
    [Table("t_cm4_resultado_exame")]
    public class ResultadoExame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CdResultado { get; set; }

        [Required]
        [StringLength(500)]
        public string DsResultado { get; set; }

        [StringLength(100)]
        public string DsObservacoes { get; set; }

        [Column(TypeName = "NUMBER(5, 2)")]
        public decimal VrResultado { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrGlobulosVermelhos { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrGlobulosBrancos { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrPlaquetas { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrHemoglobinaGlicada { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrCreatinina { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrColesterolTotal { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrColesterolHDL { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrColesterolLDL { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrTriglicerides { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public int NrHormônioTireostimulanteTSH { get; set; }

        [ForeignKey("Exame")]
        public int? TExameCdExame { get; set; }

        public Exame? Exame { get; set; }


        public ResultadoExame()
        {
        }


        public ResultadoExame(int cdResultado, string dsResultado, string dsObservacoes, decimal vrResultado, int nrGlobulosVermelhos,
                              int nrGlobulosBrancos, int nrPlaquetas, int nrHemoglobinaGlicada, int nrCreatinina, int nrColesterolTotal,
                              int nrColesterolHDL, int nrColesterolLDL, int nrTriglicerides, int nrHormônioTireostimulanteTSH, int tExameCdExame)
        {
            CdResultado = cdResultado;
            DsResultado = dsResultado;
            DsObservacoes = dsObservacoes;
            VrResultado = vrResultado;
            NrGlobulosVermelhos = nrGlobulosVermelhos;
            NrGlobulosBrancos = nrGlobulosBrancos;
            NrPlaquetas = nrPlaquetas;
            NrHemoglobinaGlicada = nrHemoglobinaGlicada;
            NrCreatinina = nrCreatinina;
            NrColesterolTotal = nrColesterolTotal;
            NrColesterolHDL = nrColesterolHDL;
            NrColesterolLDL = nrColesterolLDL;
            NrTriglicerides = nrTriglicerides;
            NrHormônioTireostimulanteTSH = nrHormônioTireostimulanteTSH;
            TExameCdExame = tExameCdExame;
        }
    }
}