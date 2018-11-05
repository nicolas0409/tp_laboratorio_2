using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace ClasesInstanciables
{
     public class Jornada
    {
        private Universidad.EClases clase;
        private List<Alumno> alumnos;
        private Profesor instructor;
        #region "constructores"
        /// <summary>
        /// constructor de instancia crea la lista de alumnos
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();

        }
        /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion
        /// <summary>
        ///  propiedad  que retorna y setea la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set { this.alumnos = value; }

        }
        /// <summary>
        /// prpiedad que retorna y setea la clase d ela jornada
        /// </summary>
        public Universidad.EClases Clase
            {   
            get
            {
                return this.clase;

            }
            set
            {
                this.clase = value;
            }

            }
        /// <summary>
        /// propiedad  que retorna y setea el instructor de la jornada
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        

        /// <summary>
        /// retorna todos los datos de la jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("CLASE DE: {0} POR {1}\n", this.Clase, this.Instructor.ToString());
            datos.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in this.Alumnos)
            {
                datos.AppendFormat("{0}\n", alumno.ToString());
            }
            datos.AppendFormat("<----------------------------------------->\n");
            return datos.ToString();
        }
      public static bool operator ==(Jornada j ,Alumno a)
        {
            bool flag = false;
            foreach (Alumno alumnoJornada in j.Alumnos)
            {
                if (alumnoJornada==a)
                    { flag = true;
                    break;
                    }
            }
            return flag;
        }
        
        public static bool  operator !=(Jornada j,Alumno a)
        {
            return !(j == a);
        }

        public static  Jornada operator +(Jornada j ,Alumno a)
        {
            if(j!=a)
            {
                j.Alumnos.Add(a);

            }
            else
            {
                AlumnoRepetidoException excepcionAlumno = new AlumnoRepetidoException();
                throw excepcionAlumno;
            }
            return j;
        }
        public static bool Guardar(Jornada jornada)
        {
            Archivos.Texto texto = new Archivos.Texto();
            //  return texto.Guardar(Environment.SpecialFolder.Desktop.ToString() + "\\ejemplo.txt", jornada.ToString());
            return texto.Guardar("Jornada.txt", jornada.ToString());

        }
        public static string Leer()
        {
            string datos;
            Archivos.Texto texto = new Archivos.Texto();
            // -texto.Leer(Environment.SpecialFolder.Desktop.ToString() + "\\ejemplo.txt", out datos);
            texto.Leer("Jornada.txt", out datos);
            return datos;
        }

    }
}
