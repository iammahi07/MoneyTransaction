using Microsoft.EntityFrameworkCore;
using MoneyTransaction.Models;

namespace MoneyTransaction.DataAccess
{
    public class TransactionDbContext:DbContext
    {
      
            public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
            { }

            public DbSet<Transaction> Transactions { get; set; }
        }
}
