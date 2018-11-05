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

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("ESTADO DE CUENTA: {0}\nTOMA CLASES DE:{1}\n", this.estadoDeCuenta, this.claseQueToma);

            return datos.ToString();
        }

        protected override string ParticiparEnClase()
        {
          return  string.Format("TOMA CLASE DE {0}",this.claseQueToma);
        }
        public override string ToString()
        {
            return  this.MostrarDatos();
        }
        public static bool operator ==(Alumno a,Universidad.EClases clase)
        {
            bool flag = true;
           if(a.estadoDeCuenta == EEstadoCuenta.Deudor ||a!=clase)
            {
                flag = false;
            }

            return flag;
        }
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {

            return (a.claseQueToma != clase);
            
            

        }
        public Alumno():base()
        { }
        //estadode cuenta pordefaul que??
        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad, Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta eEstadoDeCuenta) :this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoDeCuenta = eEstadoDeCuenta;
        }




    }
}
