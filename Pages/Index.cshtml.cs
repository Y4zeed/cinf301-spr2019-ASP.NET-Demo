using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Pages.Model;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication3.Models.WebApplication3Context _context;

        public IndexModel(WebApplication3.Models.WebApplication3Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
