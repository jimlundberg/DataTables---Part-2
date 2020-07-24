using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataTables.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataTables.Pages
{
    public class IndexModel : PageModel
    {
        private InvoiceContext _context;

        public List<InvoiceModel> InvoiceList;
        public IndexModel(InvoiceContext context)
        {
            _context = context;
        }

        // this will populate the page, if you want to show the table using the list (with foreach)
        public async Task<IActionResult> OnGet()
        {
            InvoiceList = _context.InvoiceTable.ToList();
            return Page();
        }

        //method to provide list in json format, for the ag-grid
        public JsonResult OnGetArrayData()
        {
            InvoiceList = _context.InvoiceTable.ToList();

            return new JsonResult(InvoiceList);
        }


    }
}
