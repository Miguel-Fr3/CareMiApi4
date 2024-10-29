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
        public float VrResultado { get; set; }


        [Column(TypeName = "NUMBER(5)")]
        public float NrGlobulosVermelhos { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrGlobulosBrancos { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrPlaquetas { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrHemoglobinaGlicada { get; set; }

        [Column(TypeName = "NUMBER(5, 2)")]
        public float NrCreatinina { get; set; }


        [Column(TypeName = "NUMBER(5)")]
        public float NrColesterolTotal { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrColesterolHDL { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrColesterolLDL { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrTriglicerides { get; set; }

        [Column(TypeName = "NUMBER(5)")]
        public float NrHormonioTireostimulanteTSH { get; set; } 

        [ForeignKey("Exame")]
        public int? TExameCdExame { get; set; }

        public Exame? Exame { get; set; }

        public ResultadoExame() { }

        public ResultadoExame(int cdResultado, string dsResultado, string dsObservacoes, float vrResultado,
                              int nrGlobulosVermelhos, int nrGlobulosBrancos, int nrPlaquetas, int nrHemoglobinaGlicada,
                              float nrCreatinina, int nrColesterolTotal, int nrColesterolHDL, int nrColesterolLDL,
                              int nrTriglicerides, int nrHormonioTireostimulanteTSH, int? tExameCdExame)
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
            NrHormonioTireostimulanteTSH = nrHormonioTireostimulanteTSH;
            TExameCdExame = tExameCdExame;
        }


    }
}
