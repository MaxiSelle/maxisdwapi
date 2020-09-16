using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Add_Picture_DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Picture_ClothingItems_ClothingItemId",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameIndex(
                name: "IX_Picture_ClothingItemId",
                table: "Pictures",
                newName: "IX_Pictures_ClothingItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_ClothingItems_ClothingItemId",
                table: "Pictures",
                column: "ClothingItemId",
                principalTable: "ClothingItems",
                principalColumn: "ClothingItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_ClothingItems_ClothingItemId",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_ClothingItemId",
                table: "Picture",
                newName: "IX_Picture_ClothingItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_ClothingItems_ClothingItemId",
                table: "Picture",
                column: "ClothingItemId",
                principalTable: "ClothingItems",
                principalColumn: "ClothingItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
