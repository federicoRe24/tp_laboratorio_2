using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesional : Persona, IAcciones
    {
        private EEspecialidad especialidad;

        public Profesional() : base()
        {
        }

        public EEspecialidad Especialidad
        {
            get { return especialidad; }
        }

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

    /// <summary>
    /// Enum con las especialidades médicas disponibles
    /// </summary>
    public enum EEspecialidad
    {
        Clinica,
        Pediatria,
        Psicologia,
        Traumatologia,
        Gastroenterologia,
        Oftalmologia,
    }
}
