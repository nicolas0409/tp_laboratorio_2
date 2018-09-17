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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void LaCalculadora_Load(object sender, EventArgs e)
        {
            lblResultado.Text = " ";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "Operador";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            Calculadora nCalculadora = new Calculadora();
            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);

            if (cmbOperador.Text == "/" && txtNumero2.Text == "0")
            {
                lblResultado.Text = "VALOR NO VALIDO";
            }
            else
            {
                resultado = nCalculadora.Operar(numero1, numero2, cmbOperador.Text);

                lblResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnConvertitADecimal_Click(object sender, EventArgs e)
        {

           lblResultado.Text = Entidades.Numero.BinarioADecimal(lblResultado.Text);
            


        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Entidades.Numero.DecimalBinario(lblResultado.Text);
        }
    }
}
