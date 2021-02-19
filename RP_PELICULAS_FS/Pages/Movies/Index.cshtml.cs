using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RP_PELICULAS_FS.Data;
using RP_PELICULAS_FS.Modelos;

namespace RP_PELICULAS_FS.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext _context;

        public IndexModel(RP_PELICULAS_FS.Data.RP_PELICULAS_FSContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet = true)]
        public string valor_busqueda { get; set; }  //variable donde se guarda lo que introduce el usuario

        public SelectList genero { get; set; }      //Variable donde tenemos la lista de los géneros

        [BindProperty(SupportsGet = true)]
        public string generoPelicula { get; set; }  //Variabale que guarda el género de la lista elegido por el usuario

        public async Task OnGetAsync()
        {
            var peliculas = from m in _context.Movie
                            select m;
            if (!string.IsNullOrEmpty(valor_busqueda))  // Si lo que se ha buscado no es nulo o vacío
            {
                peliculas = peliculas.Where(s => s.titulo.Contains(valor_busqueda));
            }

            //Movie = await _context.Movie.ToListAsync();
            Movie = await peliculas.ToListAsync();     //Para mostrar solo la variable pelicula que contiene la búsqueda
        }
    }
}
