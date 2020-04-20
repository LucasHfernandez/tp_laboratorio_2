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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double retorno = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            lblResultado.Text = Convert.ToString(retorno);
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();
            lblResultado.ResetText();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;

            Numero valor1 = new Numero(numero1);
            Numero valor2 = new Numero(numero2);

            return resultado = Calculadora.Operar(valor1, valor2, operador);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            /*double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            Numero binario = new Numero();
            string retorno = binario.DecimalBinario(resultado);

            lblResultado.Text = retorno;*/

            Numero numBinario = new Numero();
            lblResultado.Text = numBinario.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numDecimal = new Numero();
            lblResultado.Text = numDecimal.BinarioDecimal(lblResultado.Text);
        }
    }
}
