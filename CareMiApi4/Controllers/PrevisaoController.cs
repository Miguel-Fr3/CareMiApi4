using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.IO;
using System.Linq;
using CareMiApi4.Data;
using CareMiApi4.Models;

namespace CareMiApi4.Controllers
{
    public class PrevisaoDTO
    {
        [LoadColumn(0)] public string DsResultado { get; set; }
        [LoadColumn(1)] public float NrHormonioTireostimulanteTSH { get; set; }
        [LoadColumn(2)] public float VrResultado { get; set; }
        [LoadColumn(3)] public float NrGlobulosVermelhos { get; set; }
        [LoadColumn(4)] public float NrGlobulosBrancos { get; set; }
        [LoadColumn(5)] public float NrPlaquetas { get; set; }
        [LoadColumn(6)] public float NrHemoglobinaGlicada { get; set; }
        [LoadColumn(7)] public float NrCreatinina { get; set; }
        [LoadColumn(8)] public float NrColesterolTotal { get; set; }
        [LoadColumn(9)] public float NrColesterolHDL { get; set; }
        [LoadColumn(10)] public float NrColesterolLDL { get; set; }
        [LoadColumn(11)] public float NrTriglicerides { get; set; }
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
        private readonly string caminhoTreinamento = Path.Combine(Environment.CurrentDirectory, "Data", "exame-train.csv");
        private readonly MLContext mlContext;

        public PrevisaoController()
        {
            mlContext = new MLContext();

            if (!System.IO.File.Exists(caminhoModelo))
            {
                TreinarModelo();
            }
        }

        private void TreinarModelo()
        {
            var pastaModelo = Path.GetDirectoryName(caminhoModelo);
            if (!Directory.Exists(pastaModelo))
            {
                Directory.CreateDirectory(pastaModelo);
            }

            IDataView dadosTreinamento = mlContext.Data.LoadFromTextFile<PrevisaoDTO>(
                path: caminhoTreinamento, hasHeader: true, separatorChar: ',');

            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", "DsResultado")
                .Append(mlContext.Transforms.Concatenate("Features",
                    nameof(PrevisaoDTO.NrHormonioTireostimulanteTSH),
                    nameof(PrevisaoDTO.VrResultado), nameof(PrevisaoDTO.NrGlobulosVermelhos), nameof(PrevisaoDTO.NrGlobulosBrancos),
                    nameof(PrevisaoDTO.NrPlaquetas), nameof(PrevisaoDTO.NrHemoglobinaGlicada), nameof(PrevisaoDTO.NrCreatinina),
                    nameof(PrevisaoDTO.NrColesterolTotal), nameof(PrevisaoDTO.NrColesterolHDL), nameof(PrevisaoDTO.NrColesterolLDL),
                    nameof(PrevisaoDTO.NrTriglicerides)))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));


            var modelo = pipeline.Fit(dadosTreinamento);

            mlContext.Model.Save(modelo, dadosTreinamento.Schema, caminhoModelo);
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
