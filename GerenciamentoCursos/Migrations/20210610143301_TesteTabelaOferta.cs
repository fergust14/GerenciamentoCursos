using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class TesteTabelaOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta");

            migrationBuilder.RenameColumn(
                name: "LocalidadeId",
                table: "Oferta",
                newName: "CidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Oferta_LocalidadeId",
                table: "Oferta",
                newName: "IX_Oferta_CidadeId");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Oferta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_EstadoId",
                table: "Oferta",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_CidadeId",
                table: "Oferta",
                column: "CidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_EstadoId",
                table: "Oferta",
                column: "EstadoId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_CidadeId",
                table: "Oferta");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_EstadoId",
                table: "Oferta");

            migrationBuilder.DropIndex(
                name: "IX_Oferta_EstadoId",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Oferta");

            migrationBuilder.RenameColumn(
                name: "CidadeId",
                table: "Oferta",
                newName: "LocalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Oferta_CidadeId",
                table: "Oferta",
                newName: "IX_Oferta_LocalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_LocalidadeId",
                table: "Oferta",
                column: "LocalidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
