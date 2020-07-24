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
    public class DeleteModel : PageModel
    {
        private readonly DataTables.Data.InvoiceContext _context;

        public DeleteModel(DataTables.Data.InvoiceContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceModel = await _context.InvoiceTable.FindAsync(id);

            if (InvoiceModel != null)
            {
                _context.InvoiceTable.Remove(InvoiceModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
