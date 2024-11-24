using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Smart.CleanArch.API.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(3929),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Pessoas",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 43, DateTimeKind.Local).AddTicks(9721),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Pessoas",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 44, DateTimeKind.Local).AddTicks(72),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Enderecos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 36, DateTimeKind.Local).AddTicks(3746),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 684, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Enderecos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 40, DateTimeKind.Local).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 688, DateTimeKind.Local).AddTicks(2583));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6322),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Produtos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 693, DateTimeKind.Local).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 46, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Pessoas",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3507),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 43, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Pessoas",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 691, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 44, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Enderecos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 684, DateTimeKind.Local).AddTicks(6407),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 36, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizado",
                table: "Enderecos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 16, 26, 29, 688, DateTimeKind.Local).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2024, 11, 24, 16, 28, 0, 40, DateTimeKind.Local).AddTicks(5937));
        }
    }
}
