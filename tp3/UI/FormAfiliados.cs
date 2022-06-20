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
    }
}
