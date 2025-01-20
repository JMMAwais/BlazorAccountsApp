namespace BlazorAccountsApp.Model
{
        public class JournalEntries
        {
            public int Id { get; set; }
            public DateOnly? date { get; set; }
            public string? Description { get; set; }
            public decimal? DebutAmount { get; set; }
            public decimal? CreditAmount { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public int AccountId { get; set; }
            public Account? account { get; set; }
            public int? oppositeAccountId { get; set; }
            public Account? oppositeAccount { get; set; }
        } 
}
