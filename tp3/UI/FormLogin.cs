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
        public Dictionary<string, string> usuarios = new Dictionary<string, string>();       

        public FormLogin()
        {
            InitializeComponent();           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Empleado empleado = Empleado.GetEmpleado(txtUsuario.Text);

            //if (empleado is null)
            //    MessageBox.Show("El usuario ingresado no existe");
            //else if (empleado.Clave == txtClave.Text)
            //{

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
    }
}
