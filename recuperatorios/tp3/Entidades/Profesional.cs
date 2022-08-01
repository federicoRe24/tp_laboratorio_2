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

        public Profesional(int id, string apellido, string nombre, int dni, string email, int telefono, EEspecialidad especialidad)
        {
            this.Id = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dni;
            this.Email = email;
            this.Telefeno = telefono;
            this.especialidad = especialidad;
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
            return Apellido + ", " + Nombre + " - " + Id;
        }
    }

    /// <summary>
    /// Enum con las especialidades médicas disponibles
    /// </summary>
    public enum EEspecialidad
    {
        Clinica = 1,
        Pediatria = 2,
        Psicologia = 3,
        Traumatologia = 4,
        Gastroenterologia = 5,
        Oftalmologia = 6,
    }
}
