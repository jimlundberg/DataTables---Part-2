using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataTables.Data;

namespace DataTables
{
    public class DetailModel : PageModel
    {
        private readonly DataTables.Data.InvoiceContext _context;

        public DetailModel(DataTables.Data.InvoiceContext context)
        {
            _context = context;
        }

        public InvoiceModel InvoiceModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceModel = await _context.InvoiceTable.FirstOrDefaultAsync(m => m.ID == id);

            if (InvoiceModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
