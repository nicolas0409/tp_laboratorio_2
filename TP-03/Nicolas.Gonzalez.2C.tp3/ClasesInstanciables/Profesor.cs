using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace ClasesInstanciables
{
     public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        private void  _randomClases()
        {
          
            for (int i = 0; i < 2; i++)
            {
              this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 3));
             
                
            }
        }
        
          static Profesor()
        {
            random = new Random();

        }
        public Profesor():this(0," "," ","1",ENacionalidad.Argentino)
        {
           
        }
        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder datos = new StringBuilder("CLASES DEL DIA\n");

            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                datos.AppendFormat("{0}\n", clase);
            }
            return datos.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("{0}", this.ParticiparEnClase());
            
            return datos.ToString();
        }
        public static bool operator ==(Profesor profesor, Universidad.EClases clase)
        {
            bool flag = false;
            foreach (Universidad.EClases claseProfersor in profesor.clasesDelDia)
            {
                if(claseProfersor==clase)
                {
                    flag = true;
                    break;
                }

            }
            return flag;
        }
        public static bool operator !=(Profesor profesor, Universidad.EClases clase)
        {
            return !(profesor == clase);

        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
