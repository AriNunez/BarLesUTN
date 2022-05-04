using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string usuario;
        private string password;
        private bool esAdmin;

        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido { get { return apellido; } }
        public int Dni { get { return dni; } }
        public string NombreUsuario { get { return usuario; } }
        public bool EsAdmin { get { return esAdmin; } }

        public Usuario(string nombre, string apellido, int dni, string usuario, string password, bool esAdmin)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.password = password;
            this.esAdmin = esAdmin;
        }

        public bool CheckPassword(string password)
        {
            if(password is not null)
            {
                if(password == this.password)
                {
                    return true;
                }
            }

            return false;   
        }


    }
}
