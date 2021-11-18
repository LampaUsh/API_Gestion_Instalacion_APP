using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Gestion_Instalacion_APP.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sensor",
                table: "Sensor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operario",
                table: "Operario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instalacion",
                table: "Instalacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_App",
                table: "App");

            migrationBuilder.RenameTable(
                name: "Telefono",
                newName: "Telefonos");

            migrationBuilder.RenameTable(
                name: "Sensor",
                newName: "Sensores");

            migrationBuilder.RenameTable(
                name: "Operario",
                newName: "Operarios");

            migrationBuilder.RenameTable(
                name: "Instalacion",
                newName: "Instalaciones");

            migrationBuilder.RenameTable(
                name: "App",
                newName: "Apps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sensores",
                table: "Sensores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operarios",
                table: "Operarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instalaciones",
                table: "Instalaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apps",
                table: "Apps",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sensores",
                table: "Sensores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operarios",
                table: "Operarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instalaciones",
                table: "Instalaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apps",
                table: "Apps");

            migrationBuilder.RenameTable(
                name: "Telefonos",
                newName: "Telefono");

            migrationBuilder.RenameTable(
                name: "Sensores",
                newName: "Sensor");

            migrationBuilder.RenameTable(
                name: "Operarios",
                newName: "Operario");

            migrationBuilder.RenameTable(
                name: "Instalaciones",
                newName: "Instalacion");

            migrationBuilder.RenameTable(
                name: "Apps",
                newName: "App");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sensor",
                table: "Sensor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operario",
                table: "Operario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instalacion",
                table: "Instalacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_App",
                table: "App",
                column: "Id");
        }
    }
}
