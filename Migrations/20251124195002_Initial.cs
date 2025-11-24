using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Semana5.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_Rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_Rol);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_Usuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_Rol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles",
                        column: x => x.Id_Rol,
                        principalTable: "Roles",
                        principalColumn: "Id_Rol");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Id_Rol",
                table: "Usuarios",
                column: "Id_Rol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
