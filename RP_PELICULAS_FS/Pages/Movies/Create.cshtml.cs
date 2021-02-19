using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RP_PELICULAS_FS.Data;
using RP_PELICULAS_FS.Modelos;

namespace RP_PELICULAS_FS.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext _context;

        public CreateModel(RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
