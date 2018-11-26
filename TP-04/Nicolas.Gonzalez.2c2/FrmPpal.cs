using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
namespace Nicolas.Gonzalez._2c2
{
    public partial class FrmPpal : Form
    {
        Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
                Paquete paquete = new Paquete(txtDireccion.Text, mtxtTrakingID.Text);

                paquete.InformaEstado += paq_InformaEstado;
                paquete.EventoInformaError += InformaError;
                correo.EventoInformaError += InformaError;
                try
                    { correo += paquete; }
                    catch(TrackingRepetidoException f)
                    {
                        this.InformaError(f.Message);
                     }
                
                lstEstadoIngresado.Items.Add(paquete);
           
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
            rtxbox.Text.Guardar("Salida.txt");
        }
        private void ActualizarEstados()
        {
          
             
            
            
                lstEstadoIngresado.Items.Clear();
                lstEstadoEnViaje.Items.Clear();
                lstEstadoEntregado.Items.Clear();
                foreach (Paquete paquete in correo.Paquetes)
                {



                    if (paquete.Estado == EEstado.Ingrasado)
                    {
                        lstEstadoIngresado.Items.Add(paquete);
                    }
                    if (paquete.Estado == EEstado.EnViaje)
                    {
                        lstEstadoEnViaje.Items.Add(paquete);
                    }
                    if (paquete.Estado == EEstado.Entregado)
                    {
                        lstEstadoEntregado.Items.Add(paquete);
                    }

                }
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        public void  MostrarInformacion<T>(IMostrar<T> elemento)
            {
                if(elemento!=null)
                {
                    if(elemento.GetType()== typeof(Paquete))
                    { 
                    rtxbox.Text = ((Paquete)elemento).MostrarDatos(((Paquete)elemento));
                    }
                else
                {
                    rtxbox.Clear();
                    rtxbox.Text = correo.MostrarDatos((IMostrar<List<Paquete>>)elemento);


                }

            }
                

            }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntrga();
        }
        private void paq_InformaEstado(object sender,EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados(); 
            } 
        }
        private void InformaError(string mensaje)
        {
            MessageBox.Show(mensaje);

        }
    }
}
