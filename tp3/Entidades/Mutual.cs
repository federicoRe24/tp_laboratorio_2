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

        static Mutual()
        {
            afiliados = new List<Afiliado>();
            profesionales = new List<Profesional>();
        }

        public static List<Afiliado> Afiliados
        {
            get { return afiliados; }
        }

        public static List<Profesional> Profesionales
        {
            get { return profesionales; }
        }
    }
}

