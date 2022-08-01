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
    public partial class FormAfiliados : Form
    {
        public FormAfiliados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el listado de afiliados de la mutual
        /// </summary>
        private void Refrescar()
        {
            dgAfiliados.DataSource = AccesoDatos.LeerAfiliados();
            dgAfiliados.Update();
            dgAfiliados.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAfiliados.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea borrar este registro?", "Eliminar", MessageBoxButtons.OKCancel);
                if (result.Equals(DialogResult.OK))
                {
                    Afiliado afiliado = (Afiliado)dgAfiliados.CurrentRow.DataBoundItem;
                    AccesoDatos.EliminarAfiliado(afiliado.Id);
                    MessageBox.Show("El afiliado ha sido borrado");
                    Refrescar();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro de la grilla");
        }

        private void btnAgregarAfiliado_Click(object sender, EventArgs e)
        {
            FormAltaAfiliado frmAltaAfiliado = new FormAltaAfiliado();
            frmAltaAfiliado.ShowDialog();
            Refrescar();
        }

        private void FormAfiliados_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            Exportar("XML");
        }

        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            Exportar("JSON");
        }

        private void Exportar(string formato)
        {
            if (dgAfiliados.DataSource != null)
            {
                string ruta = SerializacionJSON.GenerarRuta("Afiliados." + formato);

                List<Afiliado> afiliados = dgAfiliados.DataSource as List<Afiliado>;

                if (formato == "JSON")
                    SerializacionJSON.SerializarAJson(ruta, afiliados);
                else
                    SerializacionXml<List<Afiliado>>.SerializarAXmlLista(ruta, afiliados);

                MessageBox.Show("Archivo generado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No hay registros que exportar");
        }
    }
}
