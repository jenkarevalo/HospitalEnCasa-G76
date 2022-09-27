using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class CambioHistoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Historias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Historias");
        }
    }
}
