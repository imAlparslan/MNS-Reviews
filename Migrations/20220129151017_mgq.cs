using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MNS_Reviews.Migrations
{
    public partial class mgq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_users_CommentOwnerId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommentOwnerId",
                table: "Comments",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CommentOwnerId",
                table: "Comments",
                newName: "IX_Comments_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_users_OwnerId",
                table: "Comments",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_users_OwnerId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Comments",
                newName: "CommentOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_OwnerId",
                table: "Comments",
                newName: "IX_Comments_CommentOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_users_CommentOwnerId",
                table: "Comments",
                column: "CommentOwnerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
