using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface serviciosLibros
    {
        void agregar(Libros libro);
        void eliminar(String isbn);
        void actualizar(String isbn);
        void mostrar();
    }
}
