using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class FormProfesionales : Form
    {
        Task cargaProfesionales;
        CancellationTokenSource cts;
        List<Profesional> listaProfesionales;
        List<Profesional> profesionalesMutual;
        Random rnd = new Random();

        public FormProfesionales()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
            cargaProfesionales = new Task(ComenzarCarga);
            listaProfesionales = new List<Profesional>();
            profesionalesMutual = AccesoDatos.LeerProfesionales();
        }

        private void ComenzarCarga()
        {

            while (true)
            {
                if (cts.IsCancellationRequested)
                {
                    return;
                }
                else if (this.dgProfesionales.InvokeRequired)
                {
                    if (profesionalesMutual.Count > 0)
                    {
                        Profesional profesional = profesionalesMutual[rnd.Next(0, profesionalesMutual.Count() - 1)];

                        listaProfesionales.Add(profesional);

                        profesionalesMutual.Remove(profesional);

                        this.dgProfesionales.BeginInvoke((MethodInvoker)delegate ()
                        {
                            dgProfesionales.DataSource = null;
                            dgProfesionales.DataSource = listaProfesionales;
                        });
                    }
                    else
                    {
                        MessageBox.Show("Carga de profesionales finalizada");
                        cts.Cancel();
                    }
                }
                Thread.Sleep(2000);
            }
        }

        private void btnComenzarCarga_Click(object sender, EventArgs e)
        {
            btnComenzarCarga.Enabled = false;
            cargaProfesionales.Start();
        }

        private void btnCancelarCarga_Click(object sender, EventArgs e)
        {
            btnCancelarCarga.Enabled = false;
            MessageBox.Show("Carga de profesionales cancelada");
            cts.Cancel();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
