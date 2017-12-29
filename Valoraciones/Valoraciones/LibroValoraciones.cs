using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        List<float> valoraciones;
    }
}
