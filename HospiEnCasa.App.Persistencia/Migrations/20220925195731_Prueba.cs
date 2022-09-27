using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospiEnCasa.App.Persistencia.Migrations
{
    public partial class Prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Enfermeras_EnfermeraId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "SignosVitales",
                newName: "Temperatura");

            migrationBuilder.RenameColumn(
                name: "Signo",
                table: "SignosVitales",
                newName: "Respiracion");

            migrationBuilder.AddColumn<string>(
                name: "PresionArterial",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pulso",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "MedicoId",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EnfermeraId",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Enfermeras_EnfermeraId",
                table: "Pacientes",
                column: "EnfermeraId",
                principalTable: "Enfermeras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Enfermeras_EnfermeraId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PresionArterial",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "Pulso",
                table: "SignosVitales");

            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "SignosVitales",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Respiracion",
                table: "SignosVitales",
                newName: "Signo");

            migrationBuilder.AlterColumn<int>(
                name: "MedicoId",
                table: "Pacientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EnfermeraId",
                table: "Pacientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Enfermeras_EnfermeraId",
                table: "Pacientes",
                column: "EnfermeraId",
                principalTable: "Enfermeras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Medicos_MedicoId",
                table: "Pacientes",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id");
        }
    }
}
