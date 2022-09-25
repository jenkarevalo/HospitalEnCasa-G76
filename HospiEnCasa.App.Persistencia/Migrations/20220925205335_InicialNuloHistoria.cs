using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class InicialNuloHistoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Historias_HistoriaId",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "HistoriaId",
                table: "Pacientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Historias_HistoriaId",
                table: "Pacientes",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Historias_HistoriaId",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "HistoriaId",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Historias_HistoriaId",
                table: "Pacientes",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
