using Microsoft.EntityFrameworkCore;

namespace BankingTransaction.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
             
        }
    }
}
