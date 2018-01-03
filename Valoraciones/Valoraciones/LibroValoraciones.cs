using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {

        List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public void PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }


    }
}
