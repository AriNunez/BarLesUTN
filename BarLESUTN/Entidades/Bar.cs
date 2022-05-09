using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Bar
    {
        private static List<Cliente> listaClientes;
        private static Dictionary<Producto,int> listaProductos;
        private static List<Usuario> listaUsuarios;
        private static Mesa[] listaMesas;

        static Bar()
        {
            listaClientes = new List<Cliente>();
            listaProductos = new Dictionary<Producto, int> { };
            listaUsuarios = new List<Usuario>();
            listaMesas = new Mesa[20];

            CargarUsuarios();
            CargarMesasYBarras();
        }

        public static void CargarUsuarios()
        {
            listaUsuarios.Add(new Usuario("admin","admin",0,"admin","admin",true));
            listaUsuarios.Add(new Usuario("Ariel","Nunez",41450812,"arielnunez","123123",false));
        }
        public static void CargarMesasYBarras()
        {
            for (int i = 0; i < listaMesas.Length; i++)
            {
                if (i < 15)
                {
                    listaMesas[i] = new Mesa(false,false);
                }
                else
                {
                    listaMesas[i] = new Mesa(false,true);
                }
            }
        }

        public static bool LoginUsuario(string usuario,string password)
        {
            if(usuario is not null && password is not null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    if(item.CheckUsuario(usuario) && item.CheckPassword(password))
                    {
                        return true;
                    }
                }
            }   
            return false;
        }
    }
}
