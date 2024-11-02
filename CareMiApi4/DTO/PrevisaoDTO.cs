using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.ML.Data;

namespace CareMiApi4.DTO
{
    [Table("t_cm4_resultado_exame")]
    public class PrevisaoDTO
    {
        [LoadColumn(0)] public float CdResultado { get; set; }
        [LoadColumn(1)] public string DsResultado { get; set; }
        [LoadColumn(2)] public string DsObservacoes { get; set; }
        [LoadColumn(3)] public float VrResultado { get; set; }
        [LoadColumn(4)] public float NrGlobulosVermelhos { get; set; }
        [LoadColumn(5)] public float NrGlobulosBrancos { get; set; }
        [LoadColumn(6)] public float NrPlaquetas { get; set; }
        [LoadColumn(7)] public float NrHemoglobinaGlicada { get; set; }
        [LoadColumn(8)] public float NrCreatinina { get; set; }
        [LoadColumn(9)] public float NrColesterolTotal { get; set; }
        [LoadColumn(10)] public float NrColesterolHDL { get; set; }
        [LoadColumn(11)] public float NrColesterolLDL { get; set; }
        [LoadColumn(12)] public float NrTriglicerides { get; set; }
        [LoadColumn(13)] public float NrHormonioTireostimulanteTSH { get; set; }
    }

    public class ExamePrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedResultado { get; set; }
    }
}
