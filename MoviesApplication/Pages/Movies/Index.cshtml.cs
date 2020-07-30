using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesApplication.Data;
using MoviesApplication.Models;

namespace MoviesApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesApplication.Data.AppDbContext _context;

        public IndexModel(MoviesApplication.Data.AppDbContext context)
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
