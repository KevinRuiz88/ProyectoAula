using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libros : Libro
    {
        int noPaginas;
        String edicion;

        public Libros()
        {
        }

        public Libros(int noPaginas, string edicion)
        {
            this.noPaginas = noPaginas;
            this.edicion = edicion;
        }

        public int getNoPaginas { get; set; }
        public String getEdicion { get; set; }

        public override string ToString()
        {
            return $"{getIsbn};{getTitulo};{getAno};{getAutor};{getCosto};{getNoPaginas};{getEdicion}";
        }
    }
}
