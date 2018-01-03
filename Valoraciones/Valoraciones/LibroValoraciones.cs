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

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach(float valoracion in valoraciones)
            {
                sumaValoraciones += valoracion;
            }

            calculo.promedioValoraciones = sumaValoraciones / valoraciones.Count;
            return calculo;
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }


    }
}
