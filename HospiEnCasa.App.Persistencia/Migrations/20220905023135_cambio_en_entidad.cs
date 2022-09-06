using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class cambio_en_entidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Registro",
                table: "Medicos",
                newName: "Especialidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Especialidad",
                table: "Medicos",
                newName: "Registro");
        }
    }
}
