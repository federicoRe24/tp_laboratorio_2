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

namespace UI
{
    public partial class FormAltaAfiliado : Form
    {
        public FormAltaAfiliado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int DNI, telefono;

            if (ValidarCampos(out DNI, out telefono))
            {
                Afiliado afiliado = new Afiliado(txtApellido.Text, txtNombre.Text, DNI, txtEmail.Text, telefono, true);
                AccesoDatos.GuardarAfiliado(afiliado);
                this.Close();
            }
        }

        private bool ValidarCampos(out int DNI, out int telefono)
        {
            DNI = 0;
            telefono = 0;
            bool resultado = false;

            if (String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtDNI.Text)
                || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (!(int.TryParse(txtDNI.Text, out DNI) && (DNI > 1000000)))
            {
                MessageBox.Show("Ingrese un DNI válido");
            }
            else if (!(int.TryParse(txtTelefono.Text, out telefono)))
            {
                MessageBox.Show("El campo Teléfono debe ser numérico");
            }
            else
                resultado = true;

            return resultado;
        }
    }
}
