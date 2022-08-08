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

        private void btnAfiliados_Click(object sender, EventArgs e)
        {
            FormAfiliados frmAfiliados = new FormAfiliados();
            frmAfiliados.ShowDialog();
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            FormProfesionales frmProfesionales = new FormProfesionales();
            frmProfesionales.ShowDialog();
        }

        private void btnAtenciones_Click(object sender, EventArgs e)
        {
            FormAtencionesDiarias formAtenciones = new FormAtencionesDiarias();
            formAtenciones.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtencionesFuturas_Click(object sender, EventArgs e)
        {
            FormAtencionesFuturas formAtencionesFuturas = new FormAtencionesFuturas();
            formAtencionesFuturas.ShowDialog();
        }
    }
}
