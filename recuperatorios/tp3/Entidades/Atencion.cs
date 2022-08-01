using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Atencion
    {
        private int idAfiliado;
        private int idProfesional;
        private DateTime fecha;

        public Atencion(int idAfiliado, int idProfesional, DateTime fecha)
        {
            this.idAfiliado = idAfiliado;
            this.idProfesional = idProfesional;
            this.fecha = fecha;
        }

        public int IdAfiliado
        {
            get { return idAfiliado; }
        }

        public int IdProfesional
        {
            get { return idProfesional; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public string MostrarDatos()
        {
            return string.Empty;
        }
    }
}
