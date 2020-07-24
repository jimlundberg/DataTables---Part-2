using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataTables.Data;
using Microsoft.EntityFrameworkCore;

namespace DataTables
{
    public class EditModel : PageModel
    {
        private readonly DataTables.Data.InvoiceContext _context;

        public EditModel(DataTables.Data.InvoiceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceModel = await _context.InvoiceTable.FirstOrDefaultAsync(m => m.ID == id);

            return Page();
        }

        [BindProperty]
        public InvoiceModel InvoiceModel { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (id==null)
            {
                return RedirectToPage("./Index");
            }

            
            if (InvoiceModel == null)
            {
                return NotFound();
            }
            InvoiceModel.ID = (int) id;
            _context.InvoiceTable.Update(InvoiceModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}