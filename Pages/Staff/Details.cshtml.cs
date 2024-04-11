using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Data;
using Hotel.Data.Identity;

namespace Hotel.Pages.Staff
{
    public class DetailsModel : PageModel
    {
        private readonly Hotel.Data.ApplicationDbContext _context;

        public DetailsModel(Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public StaffClass Staff { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == id);
            if (staff == null)
            {
                return NotFound();
            }
            else
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
