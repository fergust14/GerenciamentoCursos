using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class ChaveEstrangeira5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Localidade_LocalidadeId",
                table: "Curso");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Curso_CursoId",
                table: "Oferta");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta");

            migrationBuilder.DropIndex(
                name: "IX_Curso_LocalidadeId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "LocalidadeId",
                table: "Curso");

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadeId",
                table: "Oferta",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Oferta",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Oferta",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Curso_CursoId",
                table: "Oferta",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta",
                column: "LocalidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Curso_CursoId",
                table: "Oferta");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Oferta");

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadeId",
                table: "Oferta",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Oferta",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LocalidadeId",
                table: "Curso",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curso_LocalidadeId",
                table: "Curso",
                column: "LocalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Localidade_LocalidadeId",
                table: "Curso",
                column: "LocalidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Curso_CursoId",
                table: "Oferta",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta",
                column: "LocalidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
