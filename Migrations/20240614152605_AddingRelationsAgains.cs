using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admix.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationsAgains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_FriendUserId",
                table: "UserRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_UserId",
                table: "UserRelationships");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelationships_AspNetUsers_FriendUserId",
                table: "UserRelationships",
                column: "FriendUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelationships_AspNetUsers_UserId",
                table: "UserRelationships",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_FriendUserId",
                table: "UserRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_UserId",
                table: "UserRelationships");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelationships_AspNetUsers_FriendUserId",
                table: "UserRelationships",
                column: "FriendUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRelationships_AspNetUsers_UserId",
                table: "UserRelationships",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
