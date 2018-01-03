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

            //Asignar valoraciones
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);

            //Publicar valoraciones
            libro.PublicarValoraciones();

            //ValoracionMinima
            //ValoracionMaxima
            //PromedioValoraciones

        }
    }
}
