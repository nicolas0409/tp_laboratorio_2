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

        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            { return this == (Universitario)obj; }
            return false; 
        }


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
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        public Universitario():base()
        { }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido, dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        protected abstract string  ParticiparEnClase();
        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.ToString());
            datos.AppendFormat("LEGAJO NÚMERO:{0}\n\n", this.legajo);
            return datos.ToString();
        }

    }
}
