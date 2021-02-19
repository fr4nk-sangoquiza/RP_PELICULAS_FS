using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RP_PELICULAS_FS.Modelos;

namespace RP_PELICULAS_FS.Data
{
    public class RP_PELICULAS_FSContext : DbContext
    {
        public RP_PELICULAS_FSContext (DbContextOptions<RP_PELICULAS_FSContext> options)
            : base(options)
        {
        }

        public DbSet<RP_PELICULAS_FS.Modelos.Movie> Movie { get; set; }
    }
}
