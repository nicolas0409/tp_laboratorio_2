using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum EEstado
    {
        Ingrasado,
        EnViaje,
        Entregado
    };
    public delegate void DelegadoEstado(object sender, EventArgs e);
    public delegate void DelegadoInforError(string mensaje);
    public class Paquete : IMostrar<Paquete>
    {
       

        private string direccionEntrega;
        private EEstado estado;
        private string trakingID;
        public event DelegadoEstado InformaEstado;
        public event DelegadoInforError EventoInformaError;

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public string TrakingID
        {
            get
            {
                return this.trakingID;
            }
            set
            {
                this.trakingID = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

       
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public Paquete(string direccionEntrega,string trakickingID )
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrakingID = trakickingID;
            this.Estado = EEstado.Ingrasado;
        }
        
        public void MockCicloDeVida()
        {
            Thread.Sleep(4000);

            this.Estado = EEstado.EnViaje;
            this.InformaEstado(null,null);
            Thread.Sleep(4000);
            this.Estado = EEstado.Entregado;
            this.InformaEstado(null,null);
           try
            {
                PaqueteDAO.Insertar(this);
            }
            catch(Exception e)
            {
                this.EventoInformaError(e.Message);

            }
            
            
            
            


        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).TrakingID, ((Paquete)elemento).DireccionEntrega);
        }

        public static bool operator ==(Paquete p1,Paquete p2)
        {
            bool flag = false;
            if(p1.TrakingID==p2.TrakingID)
            {
                flag = true;
            }
            return flag;
        }
        public static bool operator !=(Paquete p1,Paquete p2)
        {
            return !(p1 == p2);
        }

    }
}
