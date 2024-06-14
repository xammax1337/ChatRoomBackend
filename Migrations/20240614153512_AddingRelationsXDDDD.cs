using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admix.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationsXDDDD : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserRelationships",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_UserId",
                table: "UserRelationships",
                column: "UserId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_FriendUserId",
                table: "UserRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRelationships_AspNetUsers_UserId",
                table: "UserRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships");

            migrationBuilder.DropIndex(
                name: "IX_UserRelationships_UserId",
                table: "UserRelationships");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRelationships");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships",
                columns: new[] { "UserId", "FriendUserId" });

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
    }
}
