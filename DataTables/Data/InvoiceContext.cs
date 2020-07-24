using Microsoft.EntityFrameworkCore;

namespace DataTables.Data
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options)
            : base(options)
        {
        }

        public DbSet<InvoiceModel> InvoiceTable { get; set; }
    }
}
