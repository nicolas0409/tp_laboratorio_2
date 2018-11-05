using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace EntidadesAbstractas
{
    public abstract  class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        };

        private int dni;
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
       

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
               
                    this.apellido = Persona.ValidarNombreApellido(value);
                
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
              this.dni =Persona.ValidarDni(this.Nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad {
            get
            {
                return this.nacionalidad;
            }
            set
            { this.nacionalidad= value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = Persona.ValidarNombreApellido(value);
            }

        }
        public string  StringToDni
        {
            set
            {
               
                    this.dni = Persona.ValidarDni(this.nacionalidad, Persona.ValidarDni(this.nacionalidad, value));
                
            }
        }

        private static  int ValidarDni(ENacionalidad nacionalidad,int  dato)
        {
            if ((nacionalidad == ENacionalidad.Argentino && (dato < 1 || dato > 89999999)) || (nacionalidad == ENacionalidad.Extranjero && (dato < 90000000 || dato > 99999999)))
            {
                NacionalidadInvalidaException exception = new NacionalidadInvalidaException();

                throw exception;
            }
            else
            {
                return dato;
            }
        }
        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int numero;
            bool flag = true;
            if (dato.Length >8)
               flag = false;
            foreach (char c in dato)
            {
                if(!(char.IsDigit(c)))
                {
                    flag = false;
                    break;
                }
            }
            
            if(flag==false)
            {
                DniInvalidoException ExcepcionDni = new DniInvalidoException("Formato incorrecto de dni");
                throw ExcepcionDni;
            }
            else
            {
                int.TryParse(dato, out numero);
                return numero;
            }
        }
        private  static  String ValidarNombreApellido(string dato)
        {
            bool flag = true;

            foreach (char c in dato)
            {
                if (!(char.IsLetter(c)))
                {
                    flag = false;
                    break;

                }
            }
            if (flag == false)
            {

                dato = "";
            }
            
             return dato; 

        }
        public Persona()
        {
            this.nombre = " ";
            this.apellido = " ";
            this.Nacionalidad = ENacionalidad.Argentino;
            this.dni = 1;
        }
        public Persona(string nombre,string apellido,ENacionalidad nacionalidad)
        {
            this.Nombre=nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.Dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.StringToDni = dni;
        }
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNacionalidad:{2}\n\n", this.Apellido, this.Nombre, this.Nacionalidad);
            return datos.ToString();
        }

    }
}
