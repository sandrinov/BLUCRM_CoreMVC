using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class ver_04_with_fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_AuthorID",
                table: "Movie",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Author_AuthorID",
                table: "Movie",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Author_AuthorID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_AuthorID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Movie");
        }
    }
}
