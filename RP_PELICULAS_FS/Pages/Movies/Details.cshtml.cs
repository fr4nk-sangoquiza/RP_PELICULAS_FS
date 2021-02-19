using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RP_PELICULAS_FS.Data;
using RP_PELICULAS_FS.Modelos;

namespace RP_PELICULAS_FS.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext _context;

        public DetailsModel(RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
