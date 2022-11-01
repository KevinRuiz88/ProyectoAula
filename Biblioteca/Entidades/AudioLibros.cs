using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AudioLibros : Libro
    {
        String tiempo;
        String formato;
        String peso;

        public AudioLibros()
        {
        }

        public AudioLibros(string tiempo, string formato, string peso)
        {
            this.tiempo = tiempo;
            this.formato = formato;
            this.peso = peso;
        }

        public String getTiempo { get; set; }
        public String getFormato { get; set; }
        public string getPeso { get; set; }


        public override string ToString()
        {
            return $"{getIsbn};{getTitulo};{getAno};{getAutor};{getCosto};{getTiempo};{getFormato};{getPeso}";
        }

    }
}
