using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
   public  class Correo:IMostrar<List<Paquete>>
    {
        private static List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        public event DelegadoInforError EventoInformaError;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }

            set
            {
                this.paquetes = value;
            }

        }

        public  Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
            

        }
      
       

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder datos = new StringBuilder();
            
            foreach (Paquete paqueteLista in this.paquetes)
            {
                datos.AppendFormat("{0}({1})\n", paqueteLista.ToString(),paqueteLista.Estado);
            }
            return datos.ToString();
        }

        public static Correo operator +(Correo c,Paquete p)
        {
            if (c != null)
            {
                foreach (Paquete paqueteList in c.Paquetes)
                {
                    if (paqueteList == p)
                    {
                        throw new TrackingRepetidoException(string.Format("El Tracking ID {0} ya figura en la lista de envios", p.TrakingID));

                    }
                }
            }
            c.Paquetes.Add(p);
            Thread thread = new Thread(p.MockCicloDeVida);
            
            thread.Start();
            mockPaquetes.Add(thread);

            return c;
        }


        public void FinEntrga()
        {
            try
            {
                foreach (Thread thread in mockPaquetes)
                {
                    if(thread.IsAlive)
                    { thread.Abort(); }
                    
                }
            }
            catch(Exception)
            {

            }
        }
    }
}
