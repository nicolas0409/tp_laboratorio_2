using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
     public class Universidad
    {

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        };

        private List<Alumno> alumnos;
        private List<Profesor> Instructores;
        private List<Jornada> jornada;

        public List<Alumno> Alumnos {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;

            }
        }
        public List<Jornada> Jornada
        {
            get
            {
                return this.jornada;
            }

            set
            {
                this.jornada = value;

            }
        }
        public List<Profesor> Profersores
        {
            get
            {
                return this.Instructores;
            }

            set
            {
                this.Instructores = value;

            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        public static bool operator ==(Universidad u,Alumno a)
        {
            bool flag = false;

            foreach (Alumno alumnoUniversida in u.Alumnos)
            {
                if(alumnoUniversida==a)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Universidad u, Alumno a)
        {
          return  !(u == a);
        }
        public static bool operator ==(Universidad u, Profesor p)
        {
            bool flag = false;

            foreach (Profesor ProfesorUniversidad in u.Profersores)
            {
                if (ProfesorUniversidad == p)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }

        public static Profesor operator ==(Universidad u,EClases clase)
        {
           
                
            foreach (Profesor profesor in u.Profersores)
            {
                if(profesor==clase)
                {
                    return profesor;
                 }
            }
                SinProfesorException sinProfesorException = new SinProfesorException();
                throw sinProfesorException;
                
           
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
           
            foreach (Profesor profesor in u.Profersores)
            {
                if (profesor != clase)
                {
                    return profesor; 
                }
              
               
            }
            return null;


        }

        public static Universidad operator +(Universidad u,Alumno a)
        {
            if(u!=a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                AlumnoRepetidoException excepcionAlumno = new AlumnoRepetidoException();
                throw excepcionAlumno;
            }
            return u;
        }
        public static Universidad operator +(Universidad u,Profesor p)
        {
            if (u != p)
            {
                u.Profersores.Add(p);
            }
            return u;
        }
        /// <summary>
        /// revisar si es necesario validar de no crer  jornadas que ya existen
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad  operator +(Universidad u,EClases clase)
        {
           
                        Jornada jornada = new Jornada(clase, u==clase);


                        foreach (Alumno alumno in u.Alumnos)
                        {
                            if(alumno==clase)
                            {
                            jornada += alumno;
                            }
                        }
                        u.Jornada.Add(jornada);

                
               
        
            return u;
     }

        private static string MostrarDatos( Universidad u)
        {
            StringBuilder datos = new StringBuilder();

            //foreach ( Alumno alumno in u.Alumnos)
            //{
            //    datos.AppendFormat("{0}",alumno.ToString());
            //}
            //foreach (Profesor profesor in u.Profersores)
            //{
            //    datos.AppendFormat("{0}",profesor.ToString());
            //}
            foreach (Jornada jornada in u.Jornada)
            {
                datos.AppendFormat("{0}",jornada.ToString());
            }
           return  datos.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool Guardar(Universidad uni)
        {
            Archivos.Xml<Universidad> texto = new Archivos.Xml<Universidad>();

         
            return texto.Guardar("Universidad.xml", uni);
        }
        public  static string Leer()
        {
            string datos;
            Archivos.Xml<string> texto = new Archivos.Xml<string>();
          
            texto.Leer("Universidad.xml", out datos);
            return datos;
        }

        public Universidad()
        {
            this.jornada= new List<Jornada>();
            this.Instructores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
        }
    }
}
