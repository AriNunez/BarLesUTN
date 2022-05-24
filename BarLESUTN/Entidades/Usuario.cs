using System;
using System.Collections.Generic;

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

        public bool ComprobarPassword(string password)
        {
            if (password is not null)
            {
                if (password == this.password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ComprobarUsuario(string usuario)
        {
            if (usuario is not null)
            {
                if (usuario == this.usuario)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EsDniValido(int dni, List<Usuario> listaUsuarios)
        {
            if (dni > 0 && listaUsuarios is not null)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.Dni == dni)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool EsNombreValido(string nombre)
        {
            char[] nombreAux = nombre.ToCharArray();

            for (int i = 0; i < nombreAux.Length; i++)
            {
                if (!Char.IsLetter(nombreAux[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsUsuarioValido(string usuario)
        {
            char[] usuarioAux = usuario.ToCharArray();

            for (int i = 0; i < usuarioAux.Length; i++)
            {
                if (!Char.IsLetterOrDigit(usuarioAux[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool NombreUsuarioExistente(string usuario, List<Usuario> listaUsuarios)
        {
            if (!string.IsNullOrEmpty(usuario) && listaUsuarios is not null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.NombreUsuario == usuario)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
