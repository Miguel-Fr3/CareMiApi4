using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareMiApi4.Migrations
{
    /// <inheritdoc />
    public partial class fixtypev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "NrTriglicerides",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrPlaquetas",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrHormonioTireostimulanteTSH",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrHemoglobinaGlicada",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrGlobulosVermelhos",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrGlobulosBrancos",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrColesterolTotal",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrColesterolLDL",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NrColesterolHDL",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5,17)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "NUMBER(5)");

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 1,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 60m, 100m, 180m, 6000m, 4500m, 5m, 2m, 250000m, 140m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 2,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 50m, 160m, 240m, 6100m, 4700m, 6m, 3m, 255000m, 200m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 3,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 70m, 80m, 150m, 5500m, 3800m, 4m, 1m, 230000m, 130m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 4,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 55m, 105m, 190m, 5900m, 4200m, 6m, 2m, 245000m, 150m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 5,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 65m, 120m, 200m, 6000m, 4600m, 5m, 2m, 260000m, 170m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 6,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 60m, 75m, 155m, 5600m, 3500m, 4m, 1m, 235000m, 125m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 7,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 40m, 170m, 250m, 6000m, 4400m, 8m, 3m, 248000m, 220m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 8,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 58m, 110m, 210m, 5700m, 4300m, 5m, 5m, 240000m, 160m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 9,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 50m, 150m, 230m, 6100m, 4500m, 5m, 2m, 245000m, 190m });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 10,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { 65m, 60m, 140m, 5200m, 3000m, 3m, 1m, 220000m, 110m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "NrTriglicerides",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrPlaquetas",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrHormonioTireostimulanteTSH",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrHemoglobinaGlicada",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrGlobulosVermelhos",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrGlobulosBrancos",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrColesterolTotal",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrColesterolLDL",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.AlterColumn<short>(
                name: "NrColesterolHDL",
                table: "t_cm4_resultado_exame",
                type: "NUMBER(5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(5,17)");

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 1,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)60, (short)100, (short)180, (short)6000, (short)4500, (short)5, (short)2, (short)-12144, (short)140 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 2,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)50, (short)160, (short)240, (short)6100, (short)4700, (short)6, (short)3, (short)-7144, (short)200 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 3,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)70, (short)80, (short)150, (short)5500, (short)3800, (short)4, (short)1, (short)-32144, (short)130 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 4,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)55, (short)105, (short)190, (short)5900, (short)4200, (short)6, (short)2, (short)-17144, (short)150 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 5,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)65, (short)120, (short)200, (short)6000, (short)4600, (short)5, (short)2, (short)-2144, (short)170 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 6,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)60, (short)75, (short)155, (short)5600, (short)3500, (short)4, (short)1, (short)-27144, (short)125 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 7,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)40, (short)170, (short)250, (short)6000, (short)4400, (short)8, (short)3, (short)-14144, (short)220 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 8,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)58, (short)110, (short)210, (short)5700, (short)4300, (short)5, (short)5, (short)-22144, (short)160 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 9,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)50, (short)150, (short)230, (short)6100, (short)4500, (short)5, (short)2, (short)-17144, (short)190 });

            migrationBuilder.UpdateData(
                table: "t_cm4_resultado_exame",
                keyColumn: "CdResultado",
                keyValue: 10,
                columns: new[] { "NrColesterolHDL", "NrColesterolLDL", "NrColesterolTotal", "NrGlobulosBrancos", "NrGlobulosVermelhos", "NrHemoglobinaGlicada", "NrHormonioTireostimulanteTSH", "NrPlaquetas", "NrTriglicerides" },
                values: new object[] { (short)65, (short)60, (short)140, (short)5200, (short)3000, (short)3, (short)1, (short)23392, (short)110 });
        }
    }
}
