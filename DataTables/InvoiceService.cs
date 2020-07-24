using DataTables.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace DataTables
{
    public class InvoiceGenerator
    {



        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InvoiceContext(serviceProvider.GetRequiredService<DbContextOptions<InvoiceContext>>()))
            {
                // Look for any board games.
                if (context.InvoiceTable.Any())
                {
                    return;   // Data was already seeded
                }

                context.InvoiceTable.AddRange(
                new InvoiceModel() { ID=1, InvoiceNumber = 1, Amount = 10, CostCategory = "Utilities", Period = "2019_11" },
                new InvoiceModel() { ID=2, InvoiceNumber = 2, Amount = 50, CostCategory = "Telephone", Period = "2019_12" },
                new InvoiceModel() { ID = 3, InvoiceNumber = 3, Amount = 30, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 4, InvoiceNumber = 4, Amount = 40, CostCategory = "Consultancy", Period = "2019_11" },
                new InvoiceModel() { ID = 5, InvoiceNumber = 5, Amount = 60, CostCategory = "Raw materials", Period = "2019_10" },
                new InvoiceModel() { ID = 6, InvoiceNumber = 6, Amount = 10, CostCategory = "Raw materials", Period = "2019_11" },
                new InvoiceModel() { ID = 7, InvoiceNumber = 7, Amount = 30, CostCategory = "Raw materials", Period = "2019_11" },
                new InvoiceModel() { ID = 8, InvoiceNumber = 8, Amount = 30, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 9, InvoiceNumber = 8, Amount = 20, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 10, InvoiceNumber = 9, Amount = 2, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 11, InvoiceNumber = 10, Amount = 24, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 12, InvoiceNumber = 11, Amount = 10, CostCategory = "Telephone", Period = "2019_11" },
                new InvoiceModel() { ID = 13, InvoiceNumber = 12, Amount = 40, CostCategory = "Consultancy", Period = "2019_12" },
                new InvoiceModel() { ID = 14, InvoiceNumber = 13, Amount = 50, CostCategory = "Services", Period = "2019_11" },
                new InvoiceModel() { ID = 15, InvoiceNumber = 14, Amount = 40, CostCategory = "Utilities", Period = "2019_11" },
                new InvoiceModel() { ID = 16, InvoiceNumber = 15, Amount = 10, CostCategory = "Services", Period = "2019_11" });

                context.SaveChanges();
            }
        }



    }
}
