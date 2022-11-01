using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Datos
{
    public class Archivo
    {

        String ruta = "Libros.txt";

        public void guardar(String datos)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(datos);
            sw.Close();

        }

        public void leer()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta, true);

                String linea = sr.ReadLine();

                while (linea != null)
                {
                    //Console.WriteLine(linea);
                    String[] datos = linea.Split(';');
                    Console.WriteLine("================= DATOS =================");
                    Console.WriteLine($"- Isbn: {datos[0]}"); 
                    Console.WriteLine($"- Titulo: {datos[1]}");
                    Console.WriteLine($"- año: {datos[2]}");
                    Console.WriteLine($"- Autor:  {datos[3]}");
                    Console.WriteLine($"- Costo:  {datos[4]}");
                    Console.WriteLine($"- No Paginas:  {datos[5]}");
                    Console.WriteLine($"- Edicion:  {datos[6]}");
                    linea = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }
    }
}
