using BlazorAccountsApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAccountsApp.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<JournalEntries> journalEntries { get; set; }
    }
}
