using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
         public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado

        };


        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoDeCuenta;
        #region "constructores"
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Alumno() : base()
        { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="eEstadoDeCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta eEstadoDeCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoDeCuenta = eEstadoDeCuenta;
        }
        #endregion
        /// <summary>
        /// recarga  la fncion mostrar datos,retorna los datos del alumno en un string
        /// </summary>
        /// <returns> los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("ESTADO DE CUENTA: {0}\nTOMA CLASES DE:{1}\n", this.estadoDeCuenta, this.claseQueToma);

            return datos.ToString();
        }
        /// <summary>
        /// construye un string con  las clases que toma el estudiante
        /// </summary>
        /// <returns>retorna en un string las clases que  ve el alumno</returns>
        protected override string ParticiparEnClase()
        {
          return  string.Format("TOMA CLASE DE {0}",this.claseQueToma);
        }
        /// <summary>
        ///  retorna todos los datos del alumno en formato string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  this.MostrarDatos();
        }
        /// <summary>
        /// compar aun alumno con una clase ,si la clase  la tienen asignada el
        /// alumno retorna verdadero
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>si la clase  la tienen asignada el
        /// alumno retorna verdadero</returns>
        public static bool operator ==(Alumno a,Universidad.EClases clase)
        {
            bool flag = true;
           if(a.estadoDeCuenta == EEstadoCuenta.Deudor ||a!=clase)
            {
                flag = false;
            }

            return flag;
        }
        /// <summary>
        /// operador de diferencia entre alumno y case
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {

            return (a.claseQueToma != clase);
            
            

        }
       



    }
}
