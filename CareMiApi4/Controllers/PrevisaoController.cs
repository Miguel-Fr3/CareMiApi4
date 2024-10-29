using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Linq;
using CareMiApi4.Data; 
using CareMiApi4.Models;

namespace CareMiApi4.Controllers
{
    public class PrevisaoDTO
    {
        [LoadColumn(0)] public int CdResultado { get; set; }
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
        public string PredictedExame { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class PrevisaoController : ControllerBase
    {
        private readonly string caminhoModelo = Path.Combine(Environment.CurrentDirectory, "wwwroot", "MLModels", "ModeloExame.zip");
        private readonly MLContext mlContext;
        private readonly AppDbContext _context;

        public PrevisaoController(AppDbContext context)
        {
            _context = context;
            mlContext = new MLContext();

            if (!System.IO.File.Exists(caminhoModelo))
            {
                TreinarModelo();
            }
        }

        private void TreinarModelo()
        {
            var dadosTreinamento = _context.ResultadoExames
                .Select(e => new PrevisaoDTO
                {
                    CdResultado = e.CdResultado,
                    DsResultado = e.DsResultado,
                    DsObservacoes = e.DsObservacoes,
                    VrResultado = e.VrResultado,
                    NrGlobulosVermelhos = e.NrGlobulosVermelhos,
                    NrGlobulosBrancos = e.NrGlobulosBrancos,
                    NrPlaquetas = e.NrPlaquetas,
                    NrHemoglobinaGlicada = e.NrHemoglobinaGlicada,
                    NrCreatinina = e.NrCreatinina,
                    NrColesterolTotal = e.NrColesterolTotal,
                    NrColesterolHDL = e.NrColesterolHDL,
                    NrColesterolLDL = e.NrColesterolLDL,
                    NrTriglicerides = e.NrTriglicerides,
                    NrHormonioTireostimulanteTSH = e.NrHormonioTireostimulanteTSH
                })
                .ToList();

            var trainingData = mlContext.Data.LoadFromEnumerable(dadosTreinamento);

            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", nameof(PrevisaoDTO.DsResultado))
                .Append(mlContext.Transforms.Concatenate("Features",
                    nameof(PrevisaoDTO.VrResultado), nameof(PrevisaoDTO.NrGlobulosVermelhos), nameof(PrevisaoDTO.NrGlobulosBrancos),
                    nameof(PrevisaoDTO.NrPlaquetas), nameof(PrevisaoDTO.NrHemoglobinaGlicada), nameof(PrevisaoDTO.NrCreatinina),
                    nameof(PrevisaoDTO.NrColesterolTotal), nameof(PrevisaoDTO.NrColesterolHDL), nameof(PrevisaoDTO.NrColesterolLDL),
                    nameof(PrevisaoDTO.NrTriglicerides), nameof(PrevisaoDTO.NrHormonioTireostimulanteTSH)))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var modelo = pipeline.Fit(trainingData);

            mlContext.Model.Save(modelo, trainingData.Schema, caminhoModelo);
        }

        [HttpPost("prever")]
        public ActionResult<ExamePrediction> PreverExame([FromBody] PrevisaoDTO dadosExame)
        {
            if (!System.IO.File.Exists(caminhoModelo))
            {
                return BadRequest("O modelo ainda não foi treinado.");
            }

            ITransformer modelo;
            using (var stream = new FileStream(caminhoModelo, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                modelo = mlContext.Model.Load(stream, out var modeloSchema);
            }

            var enginePrevisao = mlContext.Model.CreatePredictionEngine<PrevisaoDTO, ExamePrediction>(modelo);

            var previsao = enginePrevisao.Predict(dadosExame);

            return Ok(previsao);
        }
    }
}
