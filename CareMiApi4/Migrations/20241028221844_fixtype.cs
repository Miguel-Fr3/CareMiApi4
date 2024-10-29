using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareMiApi4.Migrations
{
    /// <inheritdoc />
    public partial class fixtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NrHormônioTireostimulanteTSH",
                table: "t_cm4_resultado_exame",
                newName: "NrHormonioTireostimulanteTSH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NrHormonioTireostimulanteTSH",
                table: "t_cm4_resultado_exame",
                newName: "NrHormônioTireostimulanteTSH");
        }
    }
}
