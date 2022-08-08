using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Mutual
    {
        private static List<Afiliado> afiliados;
        private static List<Profesional> profesionales;
        private static List<Atencion> atenciones;
        private static int capacidad;
        static Random rnd;

        public static event Action<bool> turnosCompletos;

        static Mutual()
        {
            afiliados = AccesoDatos.LeerAfiliados();
            profesionales = AccesoDatos.LeerProfesionales();
            atenciones = new List<Atencion>();
            capacidad = 10;
            rnd = new Random();
        }

        public static List<Afiliado> Afiliados
        {
            get { return afiliados; }
        }

        public static List<Profesional> Profesionales
        {
            get { return profesionales; }
        }

        public static List<Atencion> Atenciones
        {
            get { return atenciones; }
            set { atenciones = value; }
        }

        public static List<Atencion> AgregarNuevaAtencion()
        {

            if (atenciones.Count < capacidad)
            {
                Atencion atencion = new Atencion(afiliados[rnd.Next(0, afiliados.Count() - 1)].Id, profesionales[rnd.Next(0, afiliados.Count() - 1)].Id, DateTime.Now);
                atenciones.Add(atencion);
            }
            else
            {
                turnosCompletos.Invoke(true);
            }

            return atenciones;
        }
    }
}

