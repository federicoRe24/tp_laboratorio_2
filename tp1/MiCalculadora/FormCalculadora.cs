using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedItem = null;
            lblResultado.Text = string.Empty;
        }

        //El método Operar será estático recibirá los dos números y el operador para luego
        //llamar al método Operar de Calculadora y retornar el resultado al método de
        //evento del botón btnOperar que reflejará el resultado en el Label txtResultado.
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            return Calculadora.Operar(num1, num2, operador.ToCharArray()[0]);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(cmbOperador.SelectedItem != null)
            {
                double numero1, numero2, resultado;
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString());

                if (!double.TryParse(txtNumero1.Text, out numero1))
                    lstOperaciones.Items.Add("Error: Datos inválidos");
                else if (!double.TryParse(txtNumero2.Text, out numero2))
                    lstOperaciones.Items.Add("Error: Datos inválidos");
                else if (resultado == double.MinValue)
                    lstOperaciones.Items.Add("Error: No se puede dividir por 0");
                else
                {
                    lblResultado.Text = resultado.ToString();

                    lstOperaciones.Items.Add(numero1 + " " + cmbOperador.SelectedItem.ToString() + " " + numero2 + " = " + resultado);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != string.Empty)
                lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != string.Empty)
                lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
