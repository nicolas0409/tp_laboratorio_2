using System;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {

        private string mensajeBase;
       public DniInvalidoException():base("DNI invalido")
        { }
        public DniInvalidoException(Exception e):this("DNI invalido",e)
        { }
        public DniInvalidoException(string mensaje):base(mensaje)
        { mensajeBase = mensaje; }
        public DniInvalidoException(string mensaje,Exception e):base(mensaje,e)
        { mensajeBase = mensaje; }
    }
}
