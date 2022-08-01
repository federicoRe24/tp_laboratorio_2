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
    public partial class FormAtenciones : Form
    {
        public FormAtenciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el listado de afiliados de la mutual
        /// </summary>
        private void Refrescar()
        {
            dgAtenciones.DataSource = AccesoDatos.LeerAtenciones();
            dgAtenciones.Update();
            dgAtenciones.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAtenciones.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea borrar este registro?", "Eliminar", MessageBoxButtons.OKCancel);
                if (result.Equals(DialogResult.OK))
                {
                    Atencion atencion = (Atencion)dgAtenciones.CurrentRow.DataBoundItem;
                    AccesoDatos.EliminarAtencion(atencion.IdAfiliado, atencion.IdProfesional, atencion.Fecha);
                    MessageBox.Show("La atención ha sido borrada");
                    Refrescar();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro de la grilla");
        }

        private void FormAtenciones_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAgregarAtencion_Click(object sender, EventArgs e)
        {
            FormCargarAtencion frmCargarAtencion = new FormCargarAtencion();
            frmCargarAtencion.ShowDialog();
            Refrescar();
        }
    }
}
