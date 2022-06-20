using System;

namespace Entidades
{
    public class Afiliado : Persona, IAcciones
    {
        private bool isActivo;

        public Afiliado(string apellido, string nombre, int dni, string email, int telefono, bool isActivo)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dni;
            this.Email = email;
            this.Telefeno = telefono;
            this.IsActivo = isActivo;
        }

        public Afiliado(int id, string apellido, string nombre, int dni, string email, int telefono, bool isActivo) : this(apellido, nombre, dni, email, telefono, isActivo)
        {
            this.Id = id;
        }

        public bool IsActivo
        {
            get { return isActivo; }
            set { isActivo = value; }
        }

        public bool CargarAtencion()
        {
            return false;
        }

        public string MostrarDatos()
        {
            return (Id + Apellido + Nombre).ToString();
        }

        public string MostrarDatosReducido()
        {
            return string.Empty;
        }
    }
}
