using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MNS_Reviews.Migrations
{
    public partial class mg6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentOwner",
                table: "Comments",
                newName: "CommentOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentOwnerId",
                table: "Comments",
                column: "CommentOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_users_CommentOwnerId",
                table: "Comments",
                column: "CommentOwnerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_users_CommentOwnerId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentOwnerId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentOwnerId",
                table: "Comments",
                newName: "CommentOwner");
        }
    }
}
