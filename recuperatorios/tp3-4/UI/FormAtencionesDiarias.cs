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
    public partial class FormAtencionesDiarias : Form
    {
        public FormAtencionesDiarias()
        {
            InitializeComponent();
            Mutual.turnosCompletos += MostrarMensajeAgradecimiento;
            Mutual.turnosCompletos += DesactivarComponentesFormularios;
            this.Text += " " + DateTime.Now.ToShortDateString();
        }

        private void MostrarMensajeAgradecimiento(bool turnosCompletos)
        {
            if (turnosCompletos)
            {
                MessageBox.Show("Se han aogotado los turnos del día");
                this.dgAtenciones.Enabled = !turnosCompletos;
                Mutual.turnosCompletos -= MostrarMensajeAgradecimiento;
            }
        }

        private void DesactivarComponentesFormularios(bool estado)
        {
            this.btnCargarAtencion.Enabled = !estado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Mutual.Atenciones = new List<Atencion>();
            this.Close();
        }

        private void btnCargarAtencion_Click(object sender, EventArgs e)
        {
            dgAtenciones.DataSource = null;
            dgAtenciones.DataSource = Mutual.AgregarNuevaAtencion();
        }
    }
}
