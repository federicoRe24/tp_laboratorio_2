using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private int id;
        private string apellido;
        private string nombre;
        private int dni;
        private string email;
        private int telefeno;

        public int Id { get => id; set => id = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int DNI { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public int Telefeno { get => telefeno; set => telefeno = value; }
    }
}
