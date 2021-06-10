using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoCursos.Migrations
{
    public partial class TesteTabelaOferta2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferta_Localidade_EstadoId",
                table: "Oferta");

            migrationBuilder.DropIndex(
                name: "IX_Oferta_EstadoId",
                table: "Oferta");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Oferta");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Oferta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Oferta");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Oferta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_EstadoId",
                table: "Oferta",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferta_Localidade_EstadoId",
                table: "Oferta",
                column: "EstadoId",
                principalTable: "Localidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
