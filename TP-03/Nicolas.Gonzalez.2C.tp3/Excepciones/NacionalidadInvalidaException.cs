using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException() : this("La nacionalidad no  coincide con el número de DNI")
        { }
        public NacionalidadInvalidaException(String mensaje):base(mensaje)
        {
            
        }

    }
}
