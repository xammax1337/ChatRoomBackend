using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Admix.Migrations
{
    /// <inheritdoc />
    public partial class AddingRelationsAgainss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships");

            migrationBuilder.DropIndex(
                name: "IX_UserRelationships_UserId",
                table: "UserRelationships");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserRelationships",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships",
                columns: new[] { "UserId", "FriendUserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserRelationships",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRelationships",
                table: "UserRelationships",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_UserId",
                table: "UserRelationships",
                column: "UserId");
        }
    }
}
