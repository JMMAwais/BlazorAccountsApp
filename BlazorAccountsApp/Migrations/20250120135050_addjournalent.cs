using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAccountsApp.Migrations
{
    /// <inheritdoc />
    public partial class addjournalent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "journalEntryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebutAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    oppositeAccountId = table.Column<int>(type: "int", nullable: true),
                    JournalEntriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_journalEntryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_journalEntryItems_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_journalEntryItems_Accounts_oppositeAccountId",
                        column: x => x.oppositeAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_journalEntryItems_journalEntry_JournalEntriesId",
                        column: x => x.JournalEntriesId,
                        principalTable: "journalEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_journalEntryItems_AccountId",
                table: "journalEntryItems",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_journalEntryItems_JournalEntriesId",
                table: "journalEntryItems",
                column: "JournalEntriesId");

            migrationBuilder.CreateIndex(
                name: "IX_journalEntryItems_oppositeAccountId",
                table: "journalEntryItems",
                column: "oppositeAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "journalEntryItems");
        }
    }
}
