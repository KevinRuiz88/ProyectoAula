using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ImpLibros : serviciosLibros
    {

        List<Libros> libros;
        Archivo archivo = new Archivo();

        public ImpLibros()
        {
            libros = new List<Libros>();
        }

        public void actualizar(string isbn)
        {
            
        }

        public void agregar(Libros libro)
        {
            Console.WriteLine("================= DATOS =================");
            Console.Write("- Isbn: ");
            libro.getIsbn = int.Parse(Console.ReadLine());
            Console.Write("- Titulo: ");
            libro.getTitulo = Console.ReadLine();
            Console.Write("- año: ");
            libro.getAno = Console.ReadLine();
            Console.Write("- Autor: ");
            libro.getAutor = Console.ReadLine();
            Console.Write("- Costo: ");
            libro.getCosto = double.Parse(Console.ReadLine());
            Console.Write("- No Paginas: ");
            libro.getNoPaginas = int.Parse(Console.ReadLine());
            Console.Write("- Edicion: ");
            libro.getEdicion = Console.ReadLine();

            archivo.guardar(libro.ToString());
            libros.Add(libro);


        }

        public void eliminar(string isbn)
        {
            throw new NotImplementedException();
        }

        public void mostrar()
        {
            archivo.leer();
        }
    }
}
