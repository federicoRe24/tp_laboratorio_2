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
    public partial class FormProfesionales : Form
    {
        public FormProfesionales()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga el listado de afiliados de la mutual
        /// </summary>
        private void FormProfesionales_Load(object sender, EventArgs e)
        {
            dgProfesionales.DataSource = AccesoDatos.LeerProfesionales();
        }
    }
}
