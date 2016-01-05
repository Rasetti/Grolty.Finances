using Microsoft.Data.Entity;

namespace Web.Models
{
    public class GroltyFinancesWebContext : DbContext
    {
        public DbSet<TransactionType> TransactionTypes { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Period> Periods { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Currency> Currencies { get; set; }
    }
}