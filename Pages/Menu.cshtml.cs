using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MightyBurger.Data;
using MightyBurger.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightyBurger.Pages
{
    public class MenuModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MenuModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<MenuItem> MenuItems { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var query = _context.MenuItems.AsQueryable();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                query = query.Where(m => m.Name.Contains(SearchQuery));
            }

            MenuItems = await query.ToListAsync();
            return Page();
        }
    }
}
