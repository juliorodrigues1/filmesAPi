using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmeApi.Migrations
{
    public partial class filmeidNulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes");

            migrationBuilder.AlterColumn<int>(
                name: "filmeId",
                table: "Sessoes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes",
                column: "filmeId",
                principalTable: "Filmes",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes");

            migrationBuilder.AlterColumn<int>(
                name: "filmeId",
                table: "Sessoes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes",
                column: "filmeId",
                principalTable: "Filmes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
