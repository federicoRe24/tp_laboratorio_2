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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtClave.Text == "admin")
            {
                FormPrincipal frmPrincipal = new FormPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Clave inválida");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Rellena los datos de ingreso con los de un usuario Administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtClave.Text = "admin";
        }
    }
}
