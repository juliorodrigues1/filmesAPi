using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FilmeApi.Migrations
{
    public partial class cinemaefilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessoes",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Sessoes_filmeId",
                table: "Sessoes");

            migrationBuilder.DropColumn(
                name: "id",
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

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Sessoes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessoes",
                table: "Sessoes",
                columns: new[] { "filmeId", "CinemaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes",
                column: "filmeId",
                principalTable: "Filmes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessoes",
                table: "Sessoes");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Sessoes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "filmeId",
                table: "Sessoes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Sessoes",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessoes",
                table: "Sessoes",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Sessoes_filmeId",
                table: "Sessoes",
                column: "filmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Cinemas_CinemaId",
                table: "Sessoes",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_filmeId",
                table: "Sessoes",
                column: "filmeId",
                principalTable: "Filmes",
                principalColumn: "id");
        }
    }
}
