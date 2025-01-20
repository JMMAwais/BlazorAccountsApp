using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAccountsApp.Migrations
{
    /// <inheritdoc />
    public partial class AssociateBranchAndAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BranchId",
                table: "Accounts",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_branches_BranchId",
                table: "Accounts",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_branches_BranchId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_BranchId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Accounts");
        }
    }
}
