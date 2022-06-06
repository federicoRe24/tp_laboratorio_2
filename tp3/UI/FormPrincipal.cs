using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargarAtencion_Click(object sender, EventArgs e)
        {
            FormCargarAtencion formCargarAtencion = new FormCargarAtencion();
            formCargarAtencion.ShowDialog();
        }

        private void btnCargarAfiliado_Click(object sender, EventArgs e)
        {
            FormAfiliados frmAfiliados = new FormAfiliados();
            frmAfiliados.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
