using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class AtualizacaoEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Curso");

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Curso",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_TipoId",
                table: "Curso",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Tipos_TipoId",
                table: "Curso",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Tipos_TipoId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropIndex(
                name: "IX_Curso_TipoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Curso");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Curso",
                nullable: false,
                defaultValue: 0);
        }
    }
}
