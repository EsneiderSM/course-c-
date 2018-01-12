using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear el objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;

            //Asignar valoraciones
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            //Publicar valoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine(publicar.PromedioValoraciones);
            Console.WriteLine(publicar.ValoracionMax);
            Console.WriteLine(publicar.ValoracionMin);
            Console.ReadLine();
            //ValoracionMinima
            //ValoracionMaxima
            //PromedioValoraciones

        }
    }
}
