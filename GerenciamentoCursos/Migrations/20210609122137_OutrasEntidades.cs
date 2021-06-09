using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class OutrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadeId",
                table: "Curso",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Curso",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Localidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocalidadeId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oferta_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Oferta_Localidade_LocalidadeId",
                        column: x => x.LocalidadeId,
                        principalTable: "Localidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_LocalidadeId",
                table: "Curso",
                column: "LocalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_CursoId",
                table: "Oferta",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_LocalidadeId",
                table: "Oferta",
                column: "LocalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Localidade_LocalidadeId",
                table: "Curso",
                column: "LocalidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Localidade_LocalidadeId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Oferta");

            migrationBuilder.DropTable(
                name: "Localidade");

            migrationBuilder.DropIndex(
                name: "IX_Curso_LocalidadeId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "LocalidadeId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Curso");
        }
    }
}
