using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Pages.Requests
{
    public class DetailsModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public DetailsModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        public Request Request { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Request = await _context.Request.FirstOrDefaultAsync(m => m.RequestId == id);

            if (Request == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
