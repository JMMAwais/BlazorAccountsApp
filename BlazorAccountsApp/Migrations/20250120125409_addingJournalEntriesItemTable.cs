using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAccountsApp.Migrations
{
    /// <inheritdoc />
    public partial class addingJournalEntriesItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_journalEntries_Accounts_AccountId",
                table: "journalEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_journalEntries_Accounts_oppositeAccountId",
                table: "journalEntries");

            migrationBuilder.DropIndex(
                name: "IX_journalEntries_AccountId",
                table: "journalEntries");

            migrationBuilder.DropIndex(
                name: "IX_journalEntries_oppositeAccountId",
                table: "journalEntries");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "journalEntries");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "journalEntries");

            migrationBuilder.DropColumn(
                name: "DebutAmount",
                table: "journalEntries");

            migrationBuilder.DropColumn(
                name: "oppositeAccountId",
                table: "journalEntries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "journalEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "CreditAmount",
                table: "journalEntries",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DebutAmount",
                table: "journalEntries",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "oppositeAccountId",
                table: "journalEntries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_journalEntries_AccountId",
                table: "journalEntries",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_journalEntries_oppositeAccountId",
                table: "journalEntries",
                column: "oppositeAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_journalEntries_Accounts_AccountId",
                table: "journalEntries",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_journalEntries_Accounts_oppositeAccountId",
                table: "journalEntries",
                column: "oppositeAccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }
    }
}
