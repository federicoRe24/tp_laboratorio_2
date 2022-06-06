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
    public partial class FormCargarAtencion : Form
    {
        public FormCargarAtencion()
        {
            InitializeComponent();

            //if (tipo == ETipo.Bebida)
            //{
            //    lblMesa.Text = "Barra " + cliente.Mesa;
            //    lblAfiliado.Enabled = false;
            //    cmbAfiliado.Enabled = false;
            //    btnCargarAtencion.Enabled = false;
            //    btnCerrarMesa.Text = "Cerrar barra";
            //}
            //else
            //{
            //    lblMesa.Text += cliente.Mesa;
            //    CargarComidas();
            //}

            CargarAfiliados();
            CargarProfesionales();           
        }

        /// <summary>
        /// Carga el combo de afiliados de la mutual
        /// </summary>
        private void CargarAfiliados()
        {
            foreach (Afiliado afiliado in Mutual.Afiliados)
                cmbAfiliado.Items.Add(afiliado.MostrarDatosReducido());
        }

        /// <summary>
        /// Cargar el combo de profesionales de la mutual
        /// </summary>
        private void CargarProfesionales()
        {
            foreach (Profesional profesional in Mutual.Profesionales)
                cmbAfiliado.Items.Add(profesional.MostrarDatosReducido());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarAtencion_Click(object sender, EventArgs e)
        {

        }
    }
}
