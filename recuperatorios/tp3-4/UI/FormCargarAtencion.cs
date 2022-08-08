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
            CargarAfiliados();
            CargarProfesionales();
        }

        /// <summary>
        /// Carga el combo de afiliados de la mutual
        /// </summary>
        private void CargarAfiliados()
        {
            List<Afiliado> afiliados = AccesoDatos.LeerAfiliados();

            foreach (Afiliado afiliado in afiliados)
                cmbAfiliado.Items.Add(afiliado.MostrarDatos());
        }

        /// <summary>
        /// Cargar el combo de profesionales de la mutual
        /// </summary>
        private void CargarProfesionales()
        {
            List<Profesional> profesionales = AccesoDatos.LeerProfesionales();

            //foreach (Afiliado afiliado in Mutual.Afiliados)
            foreach (Profesional profesional in profesionales)
                cmbProfesional.Items.Add(profesional.MostrarDatos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarAtencion_Click(object sender, EventArgs e)
        {
            if (cmbAfiliado.SelectedItem != null && cmbProfesional.SelectedItem != null && !String.IsNullOrWhiteSpace(dtpFecha.Text))
            {
                DialogResult = MessageBox.Show("¿Desea crear la atención seleccionada?", "Cargar Atención", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string idAfiliado = cmbAfiliado.SelectedItem.ToString().Split('-')[1];
                        string idProfesional = cmbProfesional.SelectedItem.ToString().Split('-')[1];
                        DateTime fecha = dtpFecha.Value;

                        AccesoDatos.GuardarAtencion(idAfiliado, idProfesional, fecha);
                        MessageBox.Show("La atención fue cargada exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ya existe un turno para el afiliado seleccionado con ese profesional para esa fecha", "Turno existente");
                    }
                }
            }
            else
                MessageBox.Show("Debe seleccionar un afiliado, un profesional y una franja horaria");
        }
    }
}
