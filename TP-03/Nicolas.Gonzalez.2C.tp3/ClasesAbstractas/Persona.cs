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

        #region "Propiedades"
        /// <summary>
        /// propiedad para retornar y asignar apellido validando el formto del apellido 
        /// </summary>
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
        /// <summary>
        ///  Propiedad para retornar y asignar el dni con previa validacion 
        /// </summary>
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
        /// <summary>
        /// propiedad  para retornar y asignar el  campo nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad {
            get
            {
                return this.nacionalidad;
            }
            set
            { this.nacionalidad= value;
            }
        }
        /// <summary>
        /// Asigna en  campo nombre con previa validacion del formato del nombre
        /// </summary>
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
        /// <summary>
        /// Asigna el campo  dni  con previas validaciones en el formato del dni
        /// reciviendolo con formato string
        /// </summary>
        public string  StringToDni
        {
            set
            {
               
                    this.dni = Persona.ValidarDni(this.nacionalidad, Persona.ValidarDni(this.nacionalidad, value));
                
            }
        }
        #endregion

        #region "Constuctores"
        /// <summary>
        /// Constructor sin parametros asigna, valores concistentes  
        /// </summary>
        public Persona()
        {

            this.nombre = " ";
            this.apellido = " ";
            this.Nacionalidad = ENacionalidad.Argentino;
            this.dni = 1;
        }
        /// <summary>
        /// constructor de istancia
        /// </summary>
        /// <param name="nombre">nombre a ser asignado</param>
        /// <param name="apellido">apellido a ser asignado</param>
        /// <param name="nacionalidad"> nacionalidad a se asignada</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="nombre">nombre a ser asignado</param>
        /// <param name="apellido">apellido a ser asignado</param>
        /// <param name="dni">dni a ser asignado</param>
        /// <param name="nacionalidad">nacionalidad a ser asignado</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.Dni = dni;
        }
        /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="nombre">nombre a ser asignado</param>
        /// <param name="apellido">apellido a ser asignado</param>
        /// <param name="dni">dia ser asignado</param>
        /// <param name="nacionalidad">nacionalidad a ser asignada</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.StringToDni = dni;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// metodo  para validar el  valor numerico del dni
        /// debe ser entre 1 y 89999999 si es de nacionalidad argenitina, 
        /// entre 90000000  y  99999999  si es de nacionalidad  extranjera
        /// </summary>
        /// <param name="nacionalidad">tipo de nacionalidad</param>
        /// <param name="dato">dni  a ser evaluado</param>
        /// <returns></returns>
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
        /// <summary>
        /// valida e formato del  dni   conteplando que todos sus carcteres sean numericos y no
        /// tenga una extension mayor a 8
        /// </summary>
        /// <param name="nacionalidad">tipo de nacionalidad</param>
        /// <param name="dato">dni a ser evaluado</param>
        /// <returns>retorna el  valor nuemrico del dni de ser valido </returns>
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
        /// <summary>
        /// funcion  para validar el formato del apellido cumpliendo que  sean valores alphabeticos
        /// </summary>
        /// <param name="dato">apellido de la persona</param>
        /// <returns>retorna  el valor de dato si es valido  d elo contrario retorna vacio </returns>
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
        /// <summary>
        ///  construye un string con los valores de la persona
        /// </summary>
        /// <returns>retorna un string con los valores de la persona</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNacionalidad:{2}\n\n", this.Apellido, this.Nombre, this.Nacionalidad);
            return datos.ToString();
        }
        #endregion
    }
}
