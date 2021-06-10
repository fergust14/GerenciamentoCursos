using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class TesteTabelaOferta3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_CidadeId",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "Estado",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Oferta",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_CidadeId",
                table: "Oferta",
                column: "CidadeId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
