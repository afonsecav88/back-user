using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaTareas.Migrations
{
    public partial class RenombrandoTablaTareas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Descripción = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
