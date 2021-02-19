using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RP_PELICULAS_FS.Modelos
{
    public class Movie
    {
        // PROPIEDADDES O ATRIBUTOS DE LA NUEVA PÁGINA

        public int id { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Género")]
        public string genero { get; set; }

        [Display(Name = "Precio")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal precio { get; set; }

        [DataType(DataType.Date)]                       // Acortamos la fecha. Esto se muestra en la web en formato fecha
        [Display(Name = "Fecha de Lanzamiento")]        // atributo cambiamos el nombre del campo que va visualizar el usuario
        public DateTime fechaLanzamiento { get; set; }  // Representa el día, la fecha, la hora y los segundos

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }



    }
}
