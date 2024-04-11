using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel.Data;
using Hotel.Data.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Hotel.Pages.Orders
{
    [Authorize(Roles = "Admin,Staff")]
    public class IndexModel : PageModel
    {
        
        private readonly Hotel.Data.ApplicationDbContext _context;

        public IndexModel(Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
