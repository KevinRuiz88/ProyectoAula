using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public class main
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
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
            */
        }
    }
}
