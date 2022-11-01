using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidades;

namespace Presentacion
{
    public class main
    {
        static void Main(string[] args)
        {

           ImpLibros logica = new ImpLibros();
            String continuar="";
            int opcion = 0;

            do
            {

                Console.WriteLine("================= MENU ===============");
                Console.WriteLine("1. Agregar.");
                Console.WriteLine("2. Mostrar.");
                Console.Write("- Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Libros libro = new Libros();
                        logica.agregar(libro);
                        break;
                    case 2:
                        logica.mostrar();
                        break;
                }

                Console.Write("¿Deasea continuar(s/n)?: ");    
                continuar = Console.ReadLine();


            }while (continuar.Equals("s"));

        }
    }
}
