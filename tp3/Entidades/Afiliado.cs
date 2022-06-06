using System;

namespace Entidades
{
    public class Afiliado : Persona, IAcciones
    {
        public bool CargarAtencion()
        {
            return false;
        }

        public string MostrarDatos()
        {
            return string.Empty;
        }

        public string MostrarDatosReducido()
        {
            return string.Empty;
        }
    }
}
