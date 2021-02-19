using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RP_PELICULAS_FS.Modelos
{
    public class Movie
    {
        // PROPIEDADDES O ATRIBUTOS DE LA NUEVA PÁGINA

        public int id { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public decimal precio { get; set; }

        [DataType(DataType.Date)]                // Acortamos la fecha. Esto se muestra en la web en formato fecha
        public DateTime fechaLanzamiento { get; set; }      // Representa el día, la fecha, la hora y los segundos
        
        public string descripcion { get; set; }


    }
}
