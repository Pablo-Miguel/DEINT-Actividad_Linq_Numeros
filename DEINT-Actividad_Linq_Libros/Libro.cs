using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad_Linq_Libros
{
    internal class Libro
    {
        public string? Titulo { get; set; } = null;
        public int IDAutor { get; set; }
        public int FechaPublicacion { get; set; } // Year
        public int Ventas { get; set; } //Millions

    }
}
