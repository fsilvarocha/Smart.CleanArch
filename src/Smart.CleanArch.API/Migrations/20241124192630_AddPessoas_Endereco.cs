using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart.CleanArch.API.Migrations
{
    /// <inheritdoc />
    public partial class AddPessoas_Endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6322),
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3507)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3832))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Logradouro = table.Column<string>(type: "varchar(250)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    PessoaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tenante = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 684, DateTimeKind.Local).AddTicks(6407)),
                    DataAtualizado = table.Column<DateTime>(type: "Date", nullable: false, defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 688, DateTimeKind.Local).AddTicks(2583))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Enderecos",
                column: "PessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6690));
        }
    }
}
