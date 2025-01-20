using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAccountsApp.Migrations
{
    /// <inheritdoc />
    public partial class modifyJounalEntiries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "oppositeAccountId",
                table: "journalEntries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_journalEntries_oppositeAccountId",
                table: "journalEntries",
                column: "oppositeAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_journalEntries_Accounts_oppositeAccountId",
                table: "journalEntries",
                column: "oppositeAccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_journalEntries_Accounts_oppositeAccountId",
                table: "journalEntries");

            migrationBuilder.DropIndex(
                name: "IX_journalEntries_oppositeAccountId",
                table: "journalEntries");

            migrationBuilder.DropColumn(
                name: "oppositeAccountId",
                table: "journalEntries");
        }
    }
}
