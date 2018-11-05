using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
   public abstract  class Universitario :Persona  
    {

        private int legajo;

        #region constructores
        /// <summary>
        /// constructor de instancia por defecto  asigna el valor de 0 a legajo
        /// </summary>
        public Universitario() : base()
        {
            this.legajo = 0;
        }
        /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="legajo">legajo a asignar</param>
        /// <param name="nombre">nombre a asignar</param>
        /// <param name="apellido">apellido a asignar </param>
        /// <param name="dni">dni a a asignar</param>
        /// <param name="nacionalidad">nacionalidad a asignar</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region "metodos"
        /// <summary>
        /// operador  para coparar dos  universitarios
        /// son iguales si tienen el mismo dni o el mismo legajo
        /// </summary>
        /// <param name="pg1">universitario a comparar</param>
        /// <param name="pg2">universitario a comparar</param>
        /// <returns>retorna true de ser valida la igualacion  y false en caso contrario</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool flag = false;
            if (pg1.GetType() == pg2.GetType())
            {
                if (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo)
                {
                    flag = true;
                }

            }

            return flag;

        }
        /// <summary>
        /// operador  para comparar la desigualdad entre dos universitarios
        /// </summary>
        /// <param name="pg1">universitario a comprarar</param>
        /// <param name="pg2">universitario a comprarar</param>
        /// <returns>retorna tru en caso que sean diferentes,en caso contrario 
        /// reotrna true
        /// </returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
      
       /// <summary>
       /// funcion abstracta  implementtada en clases heredadas
       /// </summary>
       /// <returns></returns>
        protected abstract string  ParticiparEnClase();
        
        /// <summary>
        /// funcion virtual para retornar los datos del universitario en formato string  
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.ToString());
            datos.AppendFormat("LEGAJO NÚMERO:{0}\n\n", this.legajo);
            return datos.ToString();
        }
        /// <summary>
        ///  sobrecarga del operador equal  para comparar universitarios
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>retorna true en caso que sean del mismo tipo ,false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            { return this == (Universitario)obj; }
            return false;
        }
        #endregion
    }
}
