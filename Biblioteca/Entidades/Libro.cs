using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        int isbn;
        String titulo;
        String ano;
        String autor;
        double costo;

        public Libro()
        {
        }

        public Libro(int isbn, string titulo, string ano, string autor, double costo)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.ano = ano;
            this.autor = autor;
            this.costo = costo;
        }


        public int getIsbn { get; set; }
        public String getTitulo { get; set; }
        public String getAno { get; set; }
        public String getAutor { get; set; }
        public double getCosto { get; set; }

        public override string ToString()
        {
            return $"{getIsbn};{getTitulo};{getAno};{getAutor};{getCosto}";
        }
    }
}
