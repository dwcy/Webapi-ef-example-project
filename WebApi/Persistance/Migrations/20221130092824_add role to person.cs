using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITHS.Webapi.Migrations
{
    /// <inheritdoc />
    public partial class addroletoperson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Persons_RoleId",
                table: "Persons",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Roles_RoleId",
                table: "Persons",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Roles_RoleId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_RoleId",
                table: "Persons");
        }
    }
}
