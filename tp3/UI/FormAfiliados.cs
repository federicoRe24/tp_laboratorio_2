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
            CargarAfiliados();
        }

        /// <summary>
        /// Carga el listado de afiliados de la mutual
        /// </summary>
        private void CargarAfiliados()
        {
            foreach (Afiliado afiliado in Mutual.Afiliados)
            {
                lbAfiliados.Items.Add(afiliado.MostrarDatos());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
