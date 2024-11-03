using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareMiApi4.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_cm4_medico",
                columns: table => new
                {
                    CdMedico = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NmMedico = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DsEspecializacao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    DsCrm = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    DsEmail = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NrCelular = table.Column<int>(type: "NUMBER(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_medico", x => x.CdMedico);
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_plano_saude",
                columns: table => new
                {
                    CdPlanoSaude = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DsRazaoSocial = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NmFantasia = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NrCnpj = table.Column<long>(type: "NUMBER(14)", nullable: false),
                    NmContato = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NrTelefone = table.Column<int>(type: "NUMBER(8)", nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "DATE", nullable: false),
                    FgAtivo = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_plano_saude", x => x.CdPlanoSaude);
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_usuario",
                columns: table => new
                {
                    CdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NmUsuario = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    NrCpf = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    NrRg = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    DsNacionalidade = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NrTelefone = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    DtCadastro = table.Column<DateTime>(type: "DATE", nullable: false),
                    DsEstadoCivil = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DsProfissao = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    FgAtivo = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_usuario", x => x.CdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_login",
                columns: table => new
                {
                    CdLogin = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NrCpf = table.Column<string>(type: "NVARCHAR2(15)", maxLength: 15, nullable: false),
                    DsSenha = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    FgAtivo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_login", x => x.CdLogin);
                    table.ForeignKey(
                        name: "FK_t_cm4_login_t_cm4_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "t_cm4_usuario",
                        principalColumn: "CdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_paciente",
                columns: table => new
                {
                    CdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NmPaciente = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NrPeso = table.Column<int>(type: "NUMBER(6)", nullable: false),
                    NrAltura = table.Column<byte>(type: "NUMBER(4)", nullable: false),
                    NmGrupoSanguineo = table.Column<string>(type: "NVARCHAR2(6)", maxLength: 6, nullable: false),
                    FlSexoBiologico = table.Column<string>(type: "CHAR(1)", nullable: false),
                    UsuarioCdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_paciente", x => x.CdPaciente);
                    table.ForeignKey(
                        name: "FK_t_cm4_paciente_t_cm4_usuario_UsuarioCdUsuario",
                        column: x => x.UsuarioCdUsuario,
                        principalTable: "t_cm4_usuario",
                        principalColumn: "CdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_agendamento_exame",
                columns: table => new
                {
                    CdAgendamento = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NrCPF = table.Column<long>(type: "NUMBER(11)", nullable: false),
                    NrRG = table.Column<long>(type: "NUMBER(15)", nullable: false),
                    DsNome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DsObservacao = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: false),
                    DtAgendamento = table.Column<DateTime>(type: "DATE", nullable: false),
                    DtEnvio = table.Column<DateTime>(type: "DATE", nullable: false),
                    MedicoId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PacienteId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_agendamento_exame", x => x.CdAgendamento);
                    table.ForeignKey(
                        name: "FK_t_cm4_agendamento_exame_t_cm4_medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "t_cm4_medico",
                        principalColumn: "CdMedico");
                    table.ForeignKey(
                        name: "FK_t_cm4_agendamento_exame_t_cm4_paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "t_cm4_paciente",
                        principalColumn: "CdPaciente");
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_carteirinha",
                columns: table => new
                {
                    CdCarteirinha = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NmPaciente = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NmPlanoSaude = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NrCns = table.Column<long>(type: "NUMBER(15)", nullable: false),
                    NmEmpresa = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DsCarencia = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    DsAcomodacao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    PacienteCdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_carteirinha", x => x.CdCarteirinha);
                    table.ForeignKey(
                        name: "FK_t_cm4_carteirinha_t_cm4_paciente_PacienteCdPaciente",
                        column: x => x.PacienteCdPaciente,
                        principalTable: "t_cm4_paciente",
                        principalColumn: "CdPaciente");
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_paciente_plano_saude",
                columns: table => new
                {
                    PlanoSaudeId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PacienteId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CdPlanoPaciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NrCarteira = table.Column<long>(type: "NUMBER(15)", nullable: false),
                    DtInicio = table.Column<DateTime>(type: "DATE", nullable: false),
                    DtFim = table.Column<DateTime>(type: "DATE", nullable: false),
                    PacienteCdPaciente = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    PlanoSaudeCdPlanoSaude = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_paciente_plano_saude", x => new { x.PacienteId, x.PlanoSaudeId });
                    table.ForeignKey(
                        name: "FK_t_cm4_paciente_plano_saude_t_cm4_paciente_PacienteCdPaciente",
                        column: x => x.PacienteCdPaciente,
                        principalTable: "t_cm4_paciente",
                        principalColumn: "CdPaciente");
                    table.ForeignKey(
                        name: "FK_t_cm4_paciente_plano_saude_t_cm4_paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "t_cm4_paciente",
                        principalColumn: "CdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_cm4_paciente_plano_saude_t_cm4_plano_saude_PlanoSaudeCdPlanoSaude",
                        column: x => x.PlanoSaudeCdPlanoSaude,
                        principalTable: "t_cm4_plano_saude",
                        principalColumn: "CdPlanoSaude");
                    table.ForeignKey(
                        name: "FK_t_cm4_paciente_plano_saude_t_cm4_plano_saude_PlanoSaudeId",
                        column: x => x.PlanoSaudeId,
                        principalTable: "t_cm4_plano_saude",
                        principalColumn: "CdPlanoSaude",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_exame",
                columns: table => new
                {
                    CdExame = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DtExame = table.Column<DateTime>(type: "DATE", nullable: false),
                    DsExame = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    AgendamentoExameId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_exame", x => x.CdExame);
                    table.ForeignKey(
                        name: "FK_t_cm4_exame_t_cm4_agendamento_exame_AgendamentoExameId",
                        column: x => x.AgendamentoExameId,
                        principalTable: "t_cm4_agendamento_exame",
                        principalColumn: "CdAgendamento");
                });

            migrationBuilder.CreateTable(
                name: "t_cm4_resultado_exame",
                columns: table => new
                {
                    CdResultado = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DsResultado = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    DsObservacoes = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    VrResultado = table.Column<decimal>(type: "NUMBER(5,2)", nullable: false),
                    NrGlobulosVermelhos = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrGlobulosBrancos = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrPlaquetas = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrHemoglobinaGlicada = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrCreatinina = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrColesterolTotal = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrColesterolHDL = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrColesterolLDL = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrTriglicerides = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    NrHormônioTireostimulanteTSH = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    TExameCdExame = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cm4_resultado_exame", x => x.CdResultado);
                    table.ForeignKey(
                        name: "FK_t_cm4_resultado_exame_t_cm4_exame_TExameCdExame",
                        column: x => x.TExameCdExame,
                        principalTable: "t_cm4_exame",
                        principalColumn: "CdExame");
                });

            migrationBuilder.InsertData(
                table: "t_cm4_usuario",
                columns: new[] { "CdUsuario", "DsEstadoCivil", "DsNacionalidade", "DsProfissao", "DtCadastro", "DtNascimento", "FgAtivo", "NmUsuario", "NrCpf", "NrRg", "NrTelefone" },
                values: new object[] { 1, "casado", "BR", "estagiario", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "usuario Padrao", "Cpf123456", "rg123456", "telefone" });

            migrationBuilder.InsertData(
                table: "t_cm4_login",
                columns: new[] { "CdLogin", "DsSenha", "FgAtivo", "NrCpf", "UsuarioId" },
                values: new object[] { 1, "senha123456", 1, "Cpf123456", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_agendamento_exame_MedicoId",
                table: "t_cm4_agendamento_exame",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_agendamento_exame_PacienteId",
                table: "t_cm4_agendamento_exame",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_carteirinha_PacienteCdPaciente",
                table: "t_cm4_carteirinha",
                column: "PacienteCdPaciente",
                unique: true,
                filter: "\"PacienteCdPaciente\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_exame_AgendamentoExameId",
                table: "t_cm4_exame",
                column: "AgendamentoExameId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_login_UsuarioId",
                table: "t_cm4_login",
                column: "UsuarioId",
                unique: true,
                filter: "\"UsuarioId\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_paciente_UsuarioCdUsuario",
                table: "t_cm4_paciente",
                column: "UsuarioCdUsuario",
                unique: true,
                filter: "\"UsuarioCdUsuario\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_paciente_plano_saude_PacienteCdPaciente",
                table: "t_cm4_paciente_plano_saude",
                column: "PacienteCdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_paciente_plano_saude_PlanoSaudeCdPlanoSaude",
                table: "t_cm4_paciente_plano_saude",
                column: "PlanoSaudeCdPlanoSaude");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_paciente_plano_saude_PlanoSaudeId",
                table: "t_cm4_paciente_plano_saude",
                column: "PlanoSaudeId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cm4_resultado_exame_TExameCdExame",
                table: "t_cm4_resultado_exame",
                column: "TExameCdExame",
                unique: true,
                filter: "\"TExameCdExame\" IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_cm4_carteirinha");

            migrationBuilder.DropTable(
                name: "t_cm4_login");

            migrationBuilder.DropTable(
                name: "t_cm4_paciente_plano_saude");

            migrationBuilder.DropTable(
                name: "t_cm4_resultado_exame");

            migrationBuilder.DropTable(
                name: "t_cm4_plano_saude");

            migrationBuilder.DropTable(
                name: "t_cm4_exame");

            migrationBuilder.DropTable(
                name: "t_cm4_agendamento_exame");

            migrationBuilder.DropTable(
                name: "t_cm4_medico");

            migrationBuilder.DropTable(
                name: "t_cm4_paciente");

            migrationBuilder.DropTable(
                name: "t_cm4_usuario");
        }
    }
}
